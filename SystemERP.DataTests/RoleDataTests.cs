using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Model;
using SystemERP.Interface;

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
            int actualResult = data.GetAll().Count();
            var result = new List<Role>();
            foreach (var item in data.GetAll())
            {
                result.Add(new Role { Id = item.Id });
            }

            // Assert
            Assert.AreEqual(result.Count(), actualResult);
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
            bool actualResult = data.AddRole(role);

            // Assert
            Assert.AreEqual(true, actualResult);
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
                Name="Cajero",
            };
            RoleData data = new RoleData();

            // Act
            bool actualResult = data.ReRegister(role);

            // Assert
            Assert.AreEqual(true, actualResult);
        }
    }
}