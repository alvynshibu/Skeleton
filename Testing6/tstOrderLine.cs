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
    }
}
