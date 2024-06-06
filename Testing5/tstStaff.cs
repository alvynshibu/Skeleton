using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters;

namespace Testing5
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        }


        [TestMethod]
        public void NotificationPropertyOK() {
            
            clsStaff AnStaff = new clsStaff();

            Boolean TestData= true;

            AnStaff.Notification = TestData;

            Assert.AreEqual(AnStaff.Notification, TestData);

        }


        [TestMethod]
        public void DateOfBirthPropertyOK()
        {

            clsStaff AnStaff = new clsStaff();

            DateTime TestData = DateTime.Now.Date;

            AnStaff.DateOfBirth = TestData;

            Assert.AreEqual(AnStaff.DateOfBirth, TestData);

        }

        

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Md Sakib Sikder";
            //assign the data to the property
            AnStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "mdsakib@gmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }



        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE5 5HN";
            //assign the data to the property
            AnStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Address, TestData);
        }





        //Find Method

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create some test to data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
;
        }

        [TestMethod]

        public void TestStaffIdFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 21)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestNameFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Name != "x")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        

        [TestMethod]

        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check dateofbirth property
            if (AnStaff.DateOfBirth != Convert.ToDateTime("30/08/2002"))
            {
                OK = false;
            }
            //TEST to see that the resukt is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestEmailFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Email != "l@gmail.com")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestAddressFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Address != "kk")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestNotificationFound()
        {
            //create an instance of the class we want to  create
            clsStaff AnStaff = new clsStaff();
            //create a booolean variable to store the results of the validation
            Boolean Found = false;
            //create a booolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Notification != true)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
    }
}
