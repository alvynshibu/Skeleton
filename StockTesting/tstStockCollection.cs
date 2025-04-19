using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);

        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data
            List<clsStock> TestList = new List<clsStock>();
            //add item to the list
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);

        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //instance of class
            clsStockCollection AllStocks = new clsStockCollection();
            //test data
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Available = true;
            TestStock.StockId = 1;
            TestStock.ItemName = "Test";
            TestStock.Quantity = 1;
            TestStock.Price = 1;
            TestStock.SupplierId = 1;
            TestStock.OrderDate = DateTime.Now;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //instance of class
            clsStockCollection AllStocks = new clsStockCollection();
            //test data
            List<clsStock> TestList = new List<clsStock>();
            //add items to list
            clsStock TestItem = new clsStock();
            //set item's properties
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }
        [TestMethod]

        public void UpdateMethodOK()
        {
            //instance of class
            clsStockCollection AllStock = new clsStockCollection();
            //item of test data
            clsStock TestItem = new clsStock();
            //variabl to store primary key
            int PrimaryKey = 0;
            //set properties
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            //set thisStock to test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of test data
            TestItem.StockId = PrimaryKey;
            //modify test record
            TestItem.StockId = 2;
            TestItem.ItemName = "TestNo2";
            TestItem.Quantity = 3;
            TestItem.Price = 2;
            TestItem.SupplierId = 3;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = false;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //instanc of class
            clsStockCollection ALLStock = new clsStockCollection();
            //create test data
            clsStock TestItem = new clsStock();
            //variable storing primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 2;
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            //set thisOrder to test data
            ALLStock.ThisStock = TestItem;
            //add record
            PrimaryKey = ALLStock.Add();
            //set the primary key of the test data
            TestItem.StockId = PrimaryKey;
            //find record
            ALLStock.ThisStock.Find(PrimaryKey);
            //delete the record
            ALLStock.Delete();
            //find the record
            Boolean Found = ALLStock.ThisStock.Find(PrimaryKey);
            //test to see that record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByItemNameMethodOK()
        {
            //instance of class
            clsStockCollection ALLStock = new clsStockCollection();
            //instance of filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStock.ReportByItemName("");
            //test to see that the two values are the same
            Assert.AreEqual(ALLStock.Count, FilteredStock.Count);
        }

        [TestMethod]

        public void ReportByItemNameNoneFound()
        {
            //instance of class
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply an ItemName
            FilteredStock.ReportByItemName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByItemNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply an itemName that doesnt exist
            FilteredStock.ReportByItemName("Coke");
            //chek that correct number of records are found
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockId != 19)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockId != 1210)
                {
                    OK = false;
                }

            }

            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);


        }
    }
}



    
            