using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class
            clsOrderCollection allOrders = new ClassLibrary.clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(allOrders);

        }

        [TestMethod]

        public void OrderListOk()
        {
            //create an instance of the class
            clsOrderCollection allOrders =  new clsOrderCollection();
            //create some test data
            List<clsOrder> testList = new List<clsOrder>();
            //add item to the list
            clsOrder testItem = new clsOrder();
            //set its properties
            testItem.OrderId = 1;
            testItem.CustomerId = 1;
            testItem.StaffId = 1;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "dmu";
            testItem.DeliveryStatus = false;
            testItem.TotalAmount = (decimal)200.50;
            //add the item to the test list
            testList.Add(testItem);
            //assign the data to the property
            allOrders.OrderList = testList;
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.OrderList, testList);
        }

        [TestMethod]

        public void ThisOrderPropertyOk()
        {
            //instance of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //test data
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.StaffId = 1;
            TestOrder.DateAdded = DateTime.Now;
            TestOrder.DeliveryAddress = "dmu";
            TestOrder.DeliveryStatus = false;
            TestOrder.TotalAmount = (decimal)200.50;
            //assign the data to the property
            allOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.ThisOrder, TestOrder);
        }

        [TestMethod]

        public void ListAndCountOk()
        {
            //instance of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //test data
            List<clsOrder> testList = new List<clsOrder>();
            //add items to list
            clsOrder testItem = new clsOrder();
            //set item's properties
            testItem.OrderId = 1;
            testItem.CustomerId = 1;
            testItem.StaffId = 1;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "dmu";
            testItem.DeliveryStatus = false;
            testItem.TotalAmount = (decimal)200.50;
            //add item to the test list
            testList.Add(testItem);
            //assign data to the property
            allOrders.OrderList = testList;
            //test to see that the two values are the same
            Assert.AreEqual (allOrders.Count, testList.Count);
        }

        [TestMethod]

        public void AddMethodOk()
        {
            //instance of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder testItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            testItem.OrderId = 1;
            testItem.CustomerId = 1;
            testItem.StaffId = 1;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "dmu";
            testItem.DeliveryStatus = false;
            testItem.TotalAmount = (decimal)200.50;
            //set thisOrder to the test data
            allOrders.ThisOrder = testItem;
            //add the record
            PrimaryKey = allOrders.Add();
            //set the primary key of test data
            testItem.OrderId = PrimaryKey;
            //find the record
            allOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.ThisOrder, testItem);

        }
    }
}
