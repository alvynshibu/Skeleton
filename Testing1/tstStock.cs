using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();

            Assert.IsNotNull(aStock);
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
            string TestData = "gkgk";
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
            decimal TestData = 10;
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
        public void OrderDatePropertyOK()
        {
            clsStock aStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            aStock.OrderDate = TestData;
            Assert.AreEqual(aStock.OrderDate, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Int32 aStockId = 12;
            Found = aStock.Find(aStockId);
            Assert.IsTrue( Found);
        }

        

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.StockId != 21)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue( OK );
        }

        public void TestItemNameFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.ItemName != Convert.ToString("zee"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.Quantity != Convert.ToInt32(1233))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.Price != Convert.ToDecimal(12.3))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.SupplierId != Convert.ToInt32(23))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.Available != Convert.ToBoolean("true"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create a boolean varaible to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is Ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockId = 21;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the dateAdded property
            if (aStock.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
            {

            }
        }



    }
}
