using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;

namespace SystemERP.Data.Tests
{
    [TestClass()]
    public class EmployeeDataTests
    {
        [TestMethod()]
        public void GetActiveEmployeeTest()
        {
            // Arrange
            EmployeeData data = new EmployeeData();              

            // Act
            int actualResult = data.GetActiveEmployee().Count();

            // Assert
            Assert.AreEqual(0, actualResult);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            // Arrange
            EmployeeData data = new EmployeeData();

            // Act
            int actualResult = data.GetAll().Count();

            // Assert
            Assert.AreEqual(0, actualResult);
        }

        [TestMethod()]
        public void GetByCodeTest()
        {
            // Arrange
            EmployeeData data = new EmployeeData();

            // Act
            var actualResult = data.GetByCode(1);

            // Assert
            Assert.AreEqual("Maximiliano", actualResult.Name);
        }


    }
}