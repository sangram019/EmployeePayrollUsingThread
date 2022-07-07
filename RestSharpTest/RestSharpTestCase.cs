using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System;
using Newtonsoft.Json.Linq;

namespace RestSharpTest
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
    [TestClass]
    public class RestSharpTestCase
    {
        RestClient client;

        [TestInitialize]
        public void Setup()
        {
            client = new RestClient("http://localhost:4000");
        }
        private RestResponse getEmployeeList()
        {
            //arrange
            RestRequest request = new RestRequest("/Employee", Method.Get);

            //act 
            RestResponse response = client.Execute(request);
            return response;
        }

        [TestMethod]
        public void OnCallingGETApi_ReturnEmployeeList()
        {
            RestResponse response = getEmployeeList();

            //assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            List<Employee> dataResponse = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            Assert.AreEqual(5, dataResponse.Count);

            foreach (Employee e in dataResponse)
            {
                System.Console.WriteLine("id: " + e.id + ", Name: " + e.Name + ", Salary: " + e.Salary);
            }

        }

        [TestMethod]
        public void givenEmployee_OnPost_ShouldReturnAddedEmployee()
        {
            //arrange
            RestRequest request = new RestRequest("/Employee", Method.Post);
            JObject jobjectbody = new JObject();
            jobjectbody.Add("Name", "John");
            jobjectbody.Add("Salary", "22000");

            request.AddParameter("application/json", jobjectbody, ParameterType.RequestBody);

            //act
            RestResponse response = client.Execute(request);
            //assert
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
            Employee dataResponse = JsonConvert.DeserializeObject<Employee>(response.Content);
            Assert.AreEqual("Nitesh", dataResponse.Name);
            Assert.AreEqual("22000", dataResponse.Salary);
            System.Console.WriteLine(response.Content);
        }


    }
}