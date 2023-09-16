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
    public class CashRegisterDataTests
    {
        [TestMethod()]
        public void CreateRegisterTest()
        {
            // Arrange
            CashRegister cashRegister = new CashRegister() {
                
            };
            CashRegisterData data = new CashRegisterData();

            // Act
            int actualResult = data.CreateRegister(cashRegister);

            // Assert
            Assert.AreEqual(1, actualResult);
        }
    }
}