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
    public class RoleDataTests
    {
        [TestMethod()]
        public void GetRolesTest()
        {
            // Arrange            
            RoleData data = new RoleData();

            // Act
            int actualResult = 3;
            var result = data.GetAll().Count();

            // Assert
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod()]
        public void AddRoleTest()
        {
            // Arrange 
            RoleData data = new RoleData();
            Role role = new Role()
            {
                Name = "Cajero",
            };
            // Act
            int actualResult = data.AddRole(role);

            // Assert
            Assert.AreEqual(4, actualResult);
        }

        [TestMethod()]
        public void DeleteRoleTest()
        {
            RoleData data = new RoleData();
            Role role = new Role()
            {
                Name = "Cajero",
            };
            // Act
            bool actualResult = data.DeleteRole(role);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void ReRegisterTest()
        {
            // Arrange
            Role role = new Role()
            {
                Name = "Cajero",
            };
            RoleData data = new RoleData();

            // Act
            bool actualResult = data.ReRegister(role);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            // Arrange
            Role role = new Role()
            {
                Id= 2,
                Name = "Cajero",
            };
            RoleData data = new RoleData();

            // Act
            Role actualResult = data.GetById(role.Id);

            // Assert
            Assert.AreEqual(role.Id, actualResult.Id);
        }
    }
}