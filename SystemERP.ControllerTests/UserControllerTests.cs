using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemERP.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Interface;
using SystemERP.Model;

namespace SystemERP.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            // Arrange
            string name= "admin", password="admin";
            UserController user = new UserController();

            // Act
            bool actualResult = user.Login(name, password);

            // Assert
            Assert.AreEqual(true, actualResult);
        }
    }
}