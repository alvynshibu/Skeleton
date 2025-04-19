using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier aSupplier = new clsSupplier();
            Assert.IsNotNull(aSupplier);
        }

        [TestMethod]

        public void ActivePropertyOK()
        {
            clsSupplier aSupplier = new clsSupplier();
            Boolean TestData = true;
            aSupplier.Active = TestData;
            Assert.AreEqual(aSupplier.Active, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            int testData = 1;

            // Assign the data to the property
            aSupplier.SupplierId = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierId, testData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "Supplier Name";

            // Assign the data to the property
            aSupplier.SupplierName = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierName, testData);
        }

        [TestMethod]
        public void ContactPersonPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "John Doe";

            // Assign the data to the property
            aSupplier.SupplierContactPerson = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierContactPerson, testData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "supplier@gmail.co.uk"; // Using ".co.uk" for England-based email

            // Assign the data to the property
            aSupplier.SupplierEmail = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierEmail, testData);
        }

        [TestMethod]
        public void PhonePropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "+44 1234 567890"; // UK phone format

            // Assign the data to the property
            aSupplier.SupplierPhoneNumber = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierPhoneNumber, testData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "123 High Street, London, England, SW1A 1AA"; // Sample address in London

            // Assign the data to the property
            aSupplier.SupplierAddress = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierAddress, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierId = 1;
            //invoke the method
            Found = aSupplier.Find(SupplierId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 5;
            //invoke the method
            Found = aSupplier.Find(SupplierId);
            //check the supplier id
            if (aSupplier.SupplierId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
