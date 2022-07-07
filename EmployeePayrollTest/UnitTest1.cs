using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollUsingThread;
using System.Collections.Generic;
using System;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMaatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Sangram", PhoneNumber: "9989893532", Address: "bhadrakh", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "odisha", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "rakesh", PhoneNumber: "2345654345", Address: "balesore", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "andhra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "dinesh", PhoneNumber: "8765954564", Address: "cuttack", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "telengana", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "prajna", PhoneNumber: "9546894039", Address: "bhubaneswar", Department: "Engineer", Gender: 'F', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "keral", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "susant", PhoneNumber: "9859403854", Address: "puri", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "goa", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "biswa", PhoneNumber: "9580385784", Address: "banglore", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "kolkatta", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "aparna", PhoneNumber: "9898760987", Address: "marathalhi", Department: "Engineer", Gender: 'F', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "pune", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "abhi", PhoneNumber: "0986785044", Address: "asurali", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "indore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "rahul", PhoneNumber: "7675894854", Address: "kolkatta", Department: "Engineer", Gender: 'M', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "hydrabad", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "jyoti", PhoneNumber: "9875848774", Address: "agra", Department: "Engineer", Gender: 'F', BasicPay: 10000, Deductions: 200, TaxablePay: 2000, Tax: 1000, NetPay: 6800, City: "manali", Country: "India"));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));

        }
    }
}