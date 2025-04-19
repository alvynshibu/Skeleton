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

        [TestMethod]

        public void UpdateMethodOk()
        {
            //instance of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //item of test data
            clsOrder testItem = new clsOrder();
            //variabl to store primary key
            Int32 PrimaryKey = 0;
            //set properties
            testItem.CustomerId = 1;
            testItem.StaffId = 1;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "dmu";
            testItem.DeliveryStatus = false;
            testItem.TotalAmount = (decimal)200.50;
            //set thisOrder to test data
            allOrders.ThisOrder = testItem;
            //add the record
            PrimaryKey = allOrders.Add();
            //set the primary key of test data
            testItem.OrderId = PrimaryKey;
            //modify test record
            testItem.CustomerId = 2;
            testItem.StaffId = 4;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "de montfort university";
            testItem.DeliveryStatus = true;
            testItem.TotalAmount = (decimal)2020.50;
            //set the record based on the new tst data
            allOrders.ThisOrder = testItem;
            //update the record
            allOrders.Update();
            //find the record
            allOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThiOrder matches the test data
            Assert.AreEqual(allOrders.ThisOrder, testItem);
        }

        [TestMethod]

        public void DeleteMethodOk()
        {
            //instanc of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //create test data
            clsOrder testItem = new clsOrder();
            //variable storing primary key
            Int32 PrimaryKey = 0;
            //set its properties
            testItem.OrderId = 200;
            testItem.CustomerId = 2;
            testItem.StaffId = 4;
            testItem.DateAdded = DateTime.Now;
            testItem.DeliveryAddress = "de montfort university";
            testItem.DeliveryStatus = true;
            testItem.TotalAmount = (decimal)2020.50;
            //set thisOrder to test data
            allOrders.ThisOrder = testItem;
            //add record
            PrimaryKey = allOrders.Add();
            //set the primary key of the test data
            testItem.OrderId = PrimaryKey;
            //find record
            allOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            allOrders.ThisOrder.Find(PrimaryKey);
            //delete record
            allOrders.Delete();
            //find the record
            Boolean Found = allOrders.ThisOrder.Find(PrimaryKey);
            //test to se hat record was not found
            Assert.IsFalse( Found );
        }

        [TestMethod]

        public void ReportByDeliveryAddressMethodOk()
        {
            //instance of class
            clsOrderCollection allOrders = new clsOrderCollection();
            //instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrders.ReportByDeliveryAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(allOrders.Count, FilteredOrders.Count );
        }

        [TestMethod]

        public void ReportByDeliveryAddressNotFound()
        {
            //instance of class
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a delivery address
            FilteredOrders.ReportByDeliveryAddress("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]

        public void ReportByDeliveryAddressTestDataFound()
        {
            //instance of class
            clsOrderCollection filteredOrders = new clsOrderCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply an address that doesnt exist
            filteredOrders.ReportByDeliveryAddress("yyy yyy");
            //chek that correct number of records are found
            if(filteredOrders.Count == 2)
            {
                //check to see if first reord id43 and second equals 45
                if (filteredOrders.OrderList[0].OrderId != 43)
                {
                    OK = false;
                }
                if (filteredOrders.OrderList[1].OrderId != 45)
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
