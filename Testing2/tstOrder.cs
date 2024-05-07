using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder anOrder = new clsOrder();

            Assert.IsNotNull(anOrder);
        }

        [TestMethod]

        public void DeliveryStatusOK()
        {
            clsOrder anOrder = new clsOrder();

            Boolean TestData = true;

            anOrder.DeliveryStatus = TestData;

            Assert.AreEqual(anOrder.DeliveryStatus, TestData);
        }

        [TestMethod]

        public void OrderDateOK()
        {
            clsOrder anOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            anOrder.DateAdded = TestData;

            Assert.AreEqual(anOrder.DateAdded, TestData);
        }

        [TestMethod]

        public void CustomerIdOK()
        {
            clsOrder anOrder = new clsOrder();

            Int TestData = 1;

            anOrder.CustomerId = TestData;

            Assert.AreEqual(anOrder.CustomerId, TestData);
        }
    }
}
