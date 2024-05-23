using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);

        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);

        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.StockId = 1;
            TestStock.ItemName = "Test";
            TestStock.Quantity = 1;
            TestStock.Price = 1;
            TestStock.SupplierId = 1;
            TestStock.OrderDate = DateTime.Now;
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }
        [TestMethod]

        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            int PrimaryKey = 0;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 1;
            TestItem.Price = 1;
            TestItem.SupplierId = 2;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockId = PrimaryKey;

            TestItem.StockId = 2;
            TestItem.ItemName = "TestNo2";
            TestItem.Quantity = 3;
            TestItem.Price = 2;
            TestItem.SupplierId = 3;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = false;
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]

       public void DeleteMethodOK()
        {
            clsStockCollection ALLStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockId = 1;
            TestItem.ItemName = "Test";
            TestItem.Quantity = 2; 
            TestItem.Price = 1;
            TestItem.SupplierId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.Available = true;
            ALLStock.ThisStock = TestItem;
            PrimaryKey = ALLStock.Add();
            TestItem.StockId = PrimaryKey;
            ALLStock.ThisStock.Find(PrimaryKey);
            ALLStock.Delete();
            Boolean Found = ALLStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        }

    }

    
            


