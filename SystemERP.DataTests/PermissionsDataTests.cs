using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Interface;
using SystemERP.Model;

namespace SystemERP.Data.Tests
{
    [TestClass()]
    public class PermissionsDataTests
    {
        [TestMethod()]
        public void CreatePermissionTest()
        {
            // Arrange
            Permissions permi = new Permissions()
            {
                Description = "todos",
            };
            PermissionsData data = new PermissionsData();

            // Act
            bool actualResult = data.CreatePermission(permi);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void DeletePermissionTest()
        {
            // Arrange
            Permissions permi = new Permissions()
            {
                Id = 1,
                Description = "asdsadsad",
            };
            PermissionsData data = new PermissionsData();

            // Act
            bool actualResult = data.DeletePermission(permi);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void UpdatePermissionTest()
        {
            Permissions permi = new Permissions()
            {
                Id = 2,
                Description = "FacturacionStock",
            };
            PermissionsData data = new PermissionsData();

            // Act
            bool actualResult = data.UpdatePermission(permi);

            // Assert
            Assert.AreEqual(true, actualResult);
        }
    }
}