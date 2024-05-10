using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
        }
        
        [TestMethod]

        public void OrderLineIdOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Int32 TestData = 1;

            anOrderLine.OrderLineId = TestData;

            Assert.AreEqual(anOrderLine.OrderLineId, TestData);
        }

        [TestMethod]

        public void OrderIdOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Int32 TestData = 1;

            anOrderLine.OrderId = TestData;

            Assert.AreEqual(anOrderLine.OrderId, TestData);
        }

        [TestMethod]

        public void StockIdOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Int32 TestData = 1;

            anOrderLine.StockId = TestData;

            Assert.AreEqual(anOrderLine.StockId, TestData);
        }

        [TestMethod]

        public void QuantityOK()
        {
            clsOrderLine anOrderLine = new clsOrderLine();

            Int32 TestData = 10;

            anOrderLine.Quantity = TestData;

            Assert.AreEqual(anOrderLine.Quantity, TestData);
        }

        [TestMethod]

        public void FindMethodOk()
        {

            //instance of class
            clsOrderLine anOrderLine = new clsOrderLine();
            //boolean variable stores result of validation
            Boolean Found = false;
            //test data to use with method
            Int32 OrderLineId = 21;
            //invoke test method
            Found = anOrderLine.Find(OrderLineId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrderLineOk()
        {

            //instance of class
            clsOrderLine anOrderLine = new clsOrderLine();
            //boolean variable stores result of validation
            Boolean Found = false;
            //boolean to record if tets data is ok
            Boolean Ok = true;
            //test data to use with method
            Int32 OrderLineId = 21;
            //invoke test method
            Found = anOrderLine.Find(OrderLineId);
            //check orderline id
            if (anOrderLine.OrderLineId != 21) {
                Ok = false;
            }
            //test for result
            Assert.IsTrue(Ok);
        }

        [TestMethod]

        public void TestOrderOk()
        {

            //instance of class
            clsOrderLine anOrderLine = new clsOrderLine();
            //boolean variable stores result of validation
            Boolean Found = false;
            //boolean to record if tets data is ok
            Boolean Ok = true;
            //test data to use with method
            Int32 OrderId = 21;
            //invoke test method
            Found = anOrderLine.Find(OrderId);
            //check order id
            if (anOrderLine.OrderId != 21)
            {
                Ok = false;
            }
            //test for result
            Assert.IsTrue(Ok);
        }

        [TestMethod]

        public void TestStockOk()
        {

            //instance of class
            clsOrderLine anOrderLine = new clsOrderLine();
            //boolean variable stores result of validation
            Boolean Found = false;
            //boolean to record if tets data is ok
            Boolean Ok = true;
            //test data to use with method
            Int32 StockId = 21;
            //invoke test method
            Found = anOrderLine.Find(StockId);
            //check stock id
            if (anOrderLine.StockId != 21)
            {
                Ok = false;
            }
            //test for result
            Assert.IsTrue(Ok);
        }

        [TestMethod]

        public void TestQuantityOk()
        {

            //instance of class
            clsOrderLine anOrderLine = new clsOrderLine();
            //boolean variable stores result of validation
            Boolean Found = false;
            //boolean to record if tets data is ok
            Boolean Ok = true;
            //test data to use with method
            Int32 Quantity = 21;
            //invoke test method
            Found = anOrderLine.Find(Quantity);
            //check quantity
            if (anOrderLine.Quantity != 21)
            {
                Ok = false;
            }
            //test for result
            Assert.IsTrue(Ok);
        }
    }
}
