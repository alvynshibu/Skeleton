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
            aSupplier.Name = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Name, testData);
        }

        [TestMethod]
        public void ContactPersonPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "John Doe";

            // Assign the data to the property
            aSupplier.ContactPerson = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.ContactPerson, testData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "supplier@gmail.co.uk"; // Using ".co.uk" for England-based email

            // Assign the data to the property
            aSupplier.Email = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Email, testData);
        }

        [TestMethod]
        public void PhonePropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "+44 1234 567890"; // UK phone format

            // Assign the data to the property
            aSupplier.Phone = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Phone, testData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            // Create an instance of the class we want to test
            clsSupplier aSupplier = new clsSupplier();

            // Create some test data to assign to the property
            string testData = "123 High Street, London, England, SW1A 1AA"; // Sample address in London

            // Assign the data to the property
            aSupplier.Address = testData;

            // Test to see that the two values are the same
            Assert.AreEqual(aSupplier.Address, testData);
        }

    }
}
