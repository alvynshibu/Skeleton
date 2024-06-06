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
        //good test data
        //create some test data to pass the method
        string Name = "Sakib";
        string DateOfBirth = DateTime.Now.ToShortDateString();
        string Email = "sakib@gmail.com";
        string Address = "Leicester";
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        }


        [TestMethod]
        public void NotificationPropertyOK()
        {

            clsStaff AnStaff = new clsStaff();

            Boolean TestData = true;

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
            Int32 StaffId = 1;
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
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 1)
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
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Name != "Sakib")
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
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check dateofbirth property
            if (AnStaff.DateOfBirth != Convert.ToDateTime("29/12/2001"))
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
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Email != "sakib@gmail.com")
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
            Int32 StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Address != "Leicester")
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
            Int32 StaffId = 1;
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

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]

        public void NameMinLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]

        public void NameMin()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "n";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMinPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMaxLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMid()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void NameExtremeMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'n');

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }


        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestData = DateTime.Now.Date;

            //convert the date variable to a string variable
            string DateOfBirth = TestData.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestData;
            //set the date totodays date
            TestData = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestData = TestData.AddDays(1);

            //convert the date variable to a string variable
            string DateOfBirth = TestData.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
           //set the DateOfBirth to a non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void EmailMinLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]

        public void EmailMin()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "n";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMid()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void EmailExtremeMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'n');

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]

        public void AddressMinLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }

        [TestMethod]

        public void AddressMin()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "n";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AddressMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AddressMid()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn";

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void AddressExtremeMax()
        {
            //create an instance of the class we want to crate
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'n');

            //invoke the method
            Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");



        }
    }
}


