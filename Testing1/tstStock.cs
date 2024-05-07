using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();

            Assert.IsNotNull(aStock);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            clsStock aStock = new clsStock();
            Boolean TestData = true;
            aStock.Active = TestData;
            Assert.AreEqual(aStock.Active, TestData);
        }
        public void DateAddedPropertyOK()
        {
            clsStock astock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            astock.DateAdded = TestData;
            Assert.AreEqual(astock.DateAdded, TestData);
            {


            }
        }

        [TestMethod]
        private static void aStockIdPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.StockId = TestData;
            Assert.AreEqual(aStock.StockId, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.ItemName = TestData;
            Assert.AreEqual(aStock.ItemName, TestData);

        }

        public void QuantityPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 132;
            aStock.Quantity = TestData;
            Assert.AreEqual(aStock.Quantity, TestData);

        }

        public void PricePropertyOK()
        {
            clsStock aStock = new clsStock();
            string TestData = "LE1 2GH";
            aStock.Price = TestData;
            Assert.AreEqual(aStock.Price, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 765;
            aStock.SupplierId = TestData;
            Assert.AreEqual(aStock.SupplierId, TestData);

        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock aStock = new clsStock();
            bool TestData = true;
            aStock.Available = TestData;
            Assert.AreEqual(aStock.Available, TestData);
        }

        [TestMethod]
        public void OrderPropertyOK()
        {
            clsStock aStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            aStock.DateAdded = TestData;
            Assert.AreEqual(aStock.DateAdded, TestData);
        }
    }
}
