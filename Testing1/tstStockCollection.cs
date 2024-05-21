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
       
    }

}
