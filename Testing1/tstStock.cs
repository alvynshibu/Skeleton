using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass the method
        string ItemName = "Redbull";
        string Quantity = "2";
        string Price = "3";
        string SupplierId = "1";
        string Available = "true";
        string OrderDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        private static void aStockIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aStock.StockId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.StockId, TestData);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            string TestData = "gkgk";
            //assign the data to the property
            aStock.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.ItemName, TestData);

        }

        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            Int32 TestData = 132;
            //assign the data to the property
            aStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Quantity, TestData);

        }

        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            decimal TestData = 10;
            //assign the data to the property
            aStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Price, TestData);
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            Int32 TestData = 765;
            //assign the data to the property
            aStock.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.SupplierId, TestData);

        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //create some data to assign to the property
            bool TestData = true;
            //assign the data to the property
            aStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Available, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //assign the data to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aStock.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.OrderDate, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //assign the data to the property
            Boolean Found = false;
            //create some test data to use with the method
            Int32 aStockId = 16;
            //invoke the method
            Found = aStock.Find(aStockId);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
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
            Int32 StockId = 16;
            //invoke the method
            Found = aStock.Find(StockId);
            //check the address id
            if (aStock.StockId != 16)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

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
            if (aStock.ItemName != Convert.ToString("Redbull"))
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
            if (aStock.Quantity != Convert.ToInt32(2))
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
            if (aStock.Price != Convert.ToDecimal(2.0))
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
            if (aStock.SupplierId != Convert.ToInt32(1))
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
            if (aStock.OrderDate != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
            {

            }
        }
        [TestMethod]
        public void ItemNameMinLessone()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMin()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = "z"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = "zz"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = "zzzzzzzzz"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = "zzzzzzzzzz"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should trigger an error
            ItemName = ItemName.PadRight(31, 'z');
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = "zzzzz"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void ItemNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ItemName = ""; //this should trigger an error
            ItemName = ItemName.PadRight(100, 'z'); //this should fail
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void QuantityMinLessone()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Quantity = ""; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Quantity = "1"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PriceMinLessone()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessone()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            Price = Price.PadRight(17, '1');
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            Price = Price.PadRight(18, '1');
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error
            Price = Price.PadRight(19, '1');
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            //create some test data to pass to the method
            string DateAdded = TestDate.ToString(); //this should trigger an error
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessone()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //string c=variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}

