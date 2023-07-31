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
    }
}