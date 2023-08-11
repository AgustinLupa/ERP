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
    public class SupplierDataTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            // Arrange            
            SupplierData data = new SupplierData();

            // Act
            var actualResult = data.GetAll();

            // Assert
            Assert.AreEqual(0, actualResult.Count());
        }
    }
}