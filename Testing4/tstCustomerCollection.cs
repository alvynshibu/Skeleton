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

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 5;
            TestItem.CustomerName = "Reenu";
            TestItem.CustomerEmail = "reenuroy@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.EmailNotification = true;
            TestItem.PhoneNumber = "9182724";
            TestItem.CustomerAddress = "Ummamkunnel House";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primay key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
            
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 5;
            TestItem.CustomerName = "Reenu";
            TestItem.CustomerEmail = "reenuroy@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.EmailNotification = true;
            TestItem.PhoneNumber = "9182724";
            TestItem.CustomerAddress = "Ummamkunnel House";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.CustomerName = "Diya";
            TestItem.CustomerEmail = "diyajohny@email.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.EmailNotification = false;
            TestItem.PhoneNumber = "07799440847";
            TestItem.CustomerAddress = "21 Penrith Crescent";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerId = 5;
            TestItem.CustomerName = "Reenu";
            TestItem.CustomerEmail = "reenuroy@gmail.com";
            TestItem.RegistrationDate = DateTime.Now;
            TestItem.EmailNotification = true;
            TestItem.PhoneNumber = "9182724";
            TestItem.CustomerAddress = "Ummamkunnel House";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

    }
}
