using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;

namespace SystemERP.Controller.Tests
{
    [TestClass()]
    public class RoleControllerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {

            // Arrange            
            RoleController data = new RoleController();

            // Act
            int actualResult = 3;
            var result = data.GetAll().Count();

            // Assert
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            // Arrange            
            RoleController data = new RoleController();

            // Act
            var actualResult = new { name = "admin" };
            var result = data.GetByID(2);

            // Assert
            Assert.AreEqual(result.Name, actualResult.name);
        }

        [TestMethod()]
        public void GetActiveRoleTest()
        {
            // Arrange            
            RoleController data = new RoleController();

            // Act
            var actualResult = 3;
            var result = data.GetActiveRoles();

            // Assert
            Assert.AreEqual(result.Count(), actualResult);
        }
    }
}