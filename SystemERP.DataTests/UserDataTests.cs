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
    public class UserDataTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            // Arrange
            User user = new User()
            {
                Name = "pepito",
                Password = "7a21faf44b0006e61eae5a50d337eca75b5b6f9c2d9da3c25ecbf5df6dcc0299",
                Id_Role = 3,

            };
            UserData data = new UserData();

            // Act
            bool actualResult = data.Create(user);

            // Assert
            Assert.AreEqual(false, actualResult);


        }

        [TestMethod()]
        public void LoginTest1()
        {
            // Arrange
            User user = new User()
            {
                Name = "admin",
                Password = "asd",
            };
            UserData data = new UserData();

            // Act
            User actualResult = data.Login(user);

            // Assert
            Assert.AreEqual(null, actualResult);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            // Arrange
            User user = new User()
            {
                Id=5,
                Name = "Pepito",
                Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                Id_Role = 3,
            };
            UserData data = new UserData();

            // Act
            bool actualResult = data.Update(user);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            // Arrange
            User user = new User()
            {
                Id = 5,
            };
            UserData data = new UserData();

            // Act
            bool actualResult = data.Delete(user);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void GetAllTest()
        {
            // Arrange            
            UserData data = new UserData();

            // Act
            int actualResult = data.GetAll().Count();
            var result = new List<User>();
            foreach (var item in data.GetAll())
            {
                result.Add(new User { Id = item.id });
            }

            // Assert
            Assert.AreEqual(result.Count(), actualResult);
        }

        [TestMethod()]
        public void ReRegisterTest()
        {
            // Arrange
            User user = new User()
            {
                Id = 5,
            };
            UserData data = new UserData();

            // Act
            bool actualResult = data.ReRegister(user);

            // Assert
            Assert.AreEqual(true, actualResult);
        }

        [TestMethod()]
        public void GetActiveUserTest()
        {
            // Arrange
            UserData data = new UserData();

            // Act
            int actualResult = data.GetActiveUser().Count();
            var result = new List<User>();
            foreach (var item in data.GetActiveUser())
            {
                result.Add(new User { Id = item.id });
            }

            // Assert
            Assert.AreEqual(result.Count(), actualResult);
        }

        [TestMethod()]
        public void GetInactiveUserTest()
        {
            // Arrange
            UserData data = new UserData();

            // Act
            int actualResult = data.GetInactiveUser().Count();
            var result = new List<User>();
            foreach (var item in data.GetInactiveUser())
            {
                result.Add(new User { Id = item.id });
            }

            // Assert
            Assert.AreEqual(result.Count(), actualResult);
        }
    }
}