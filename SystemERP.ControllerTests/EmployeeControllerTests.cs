using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Controller.Tests
{
    [TestClass()]
    public class EmployeeControllerTests
    {
        [TestMethod()]
        public void CreateEmployeeTest()
        {
            // Arrange            
            EmployeeController data = new EmployeeController();
            Employee employee = new Employee() {
                Name = "Mariano0",
                LastName = "Guerra",
                Dni = 40976845,
                Code_Employee = 2
            };
            // Act
            int actualResult = 0;
            var result = data.CreateEmployee(employee.Name, employee.LastName, employee.Dni, employee.Code_Employee);

            // Assert
            Assert.AreEqual(result, actualResult);
        }
    }
}