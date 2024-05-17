using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]

        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 5;
            TestItem.EmailNotification = true;
            TestItem.CustomerName = "Reenu";
            TestItem.CustomerEmail = "reenuroy@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.CustomerAddress = "Ummamkunnel House";
            TestItem.PhoneNumber = "9182724";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerId = 5;
            TestCustomer.EmailNotification = true;
            TestCustomer.CustomerName = "Reenu";
            TestCustomer.CustomerEmail = "reenuroy@gmail.com";
            TestCustomer.RegistrationDate = DateTime.Now;
            TestCustomer.CustomerAddress = "Ummamkunnel House";
            TestCustomer.PhoneNumber = "9182724";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerId = 5;
            TestItem.EmailNotification = true;
            TestItem.CustomerName = "Reenu";
            TestItem.CustomerEmail = "reenuroy@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.CustomerAddress = "Ummamkunnel House";
            TestItem.PhoneNumber = "9182724";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
