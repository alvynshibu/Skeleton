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
        public void OrderIdOK()
        {
            clsOrder anOrder = new clsOrder();

            Int32 TestData = 2;

            anOrder.OrderId = TestData;

            Assert.AreEqual(anOrder.OrderId, TestData);
        }

        [TestMethod]

        public void DeliveryStatusOK()
        {
            clsOrder anOrder = new clsOrder();

            Boolean TestData = Convert.ToBoolean(0);

            anOrder.DeliveryStatus = TestData;

            Assert.AreEqual(anOrder.DeliveryStatus, TestData);
        }

        [TestMethod]

        public void OrderDateOK()
        {
            clsOrder anOrder = new clsOrder();

            DateTime TestData = Convert.ToDateTime("2024-05-02");

            anOrder.DateAdded = TestData;

            Assert.AreEqual(anOrder.DateAdded, TestData);
        }

        [TestMethod]

        public void CustomerIdOK()
        {
            clsOrder anOrder = new clsOrder();

            Int32 TestData = 1;

            anOrder.CustomerId = TestData;

            Assert.AreEqual(anOrder.CustomerId, TestData);
        }

        [TestMethod]

        public void DeliveryAddressOK()
        {
            clsOrder anOrder = new clsOrder();

            String TestData = "dmu";

            anOrder.DeliveryAddress = TestData;

            Assert.AreEqual(anOrder.DeliveryAddress, TestData);
        }

        [TestMethod]

        public void TotalAmountOK()
        {
            clsOrder anOrder = new clsOrder();


            anOrder.TotalAmount = (decimal)200.00;

            Assert.AreEqual(anOrder.TotalAmount, (decimal)200.03);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use within the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the order id
            if(anOrder.OrderId != 2)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 22;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the date added property
            if (anOrder.DateAdded != Convert.ToDateTime("05/02/2024"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the customer id
            if (anOrder.CustomerId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDeliveryAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the delivery address
            if (anOrder.DeliveryAddress != "dmu")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestTotalAmountFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the total amount
            if (anOrder.TotalAmount != (decimal)200.00)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDeliveryStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the delivery status
            if (anOrder.DeliveryStatus != Convert.ToBoolean(0))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
