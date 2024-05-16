using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;
using System.Dynamic;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string CustomerEmail = "reenuroy@gmail.com";
        string CustomerName = "Reenu";
        string CustomerAddress = "Ummamkunnel House";
        string PhoneNumber = "9182724";
        string RegistrationDate = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an insstance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void EmailNotificationPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.EmailNotification = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.EmailNotification, TestData);
        }

        [TestMethod]
        public void RegistrationDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.RegistrationDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.RegistrationDate, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Alvyn";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "alvynshibu@gmail.com";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07341251831";
            //assign the data to the property
            ACustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "1 Lineker Road, Leicester, LE2 7FZ";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the customer id
            if (ACustomer.CustomerId != 5)
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestEmailNotificationFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the email notifications
            if (ACustomer.EmailNotification != true)
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestRegistrationDateFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the registration date
            if (ACustomer.RegistrationDate != Convert.ToDateTime("02/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the customer name
            if (ACustomer.CustomerName != "Reenu")
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the customer email
            if (ACustomer.CustomerEmail != "reenuroy@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the phone number
            if (ACustomer.PhoneNumber != "9182724")
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the customer address
            if (ACustomer.CustomerAddress != "Ummamkunnel House")
            {
                OK = false;
            }
            //test to see that the result is corect
            Assert.IsTrue(OK);

        }


        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the clas we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //invoke the methd
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerName = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerName = "aa"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(29, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(30, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(15, 'a'); //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(31, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = ""; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aa"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(44, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(45, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(47, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(22, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = ""; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(254, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

      

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(255, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(301, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(127, 'a');

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "1"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "11"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(14, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(15, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(500, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(16, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(7, '1');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void RegistrationDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void RegistrationDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string RegistrationDate = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RegistrationDateInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the RegistrationDate to a non date value
            string RegistrationDate = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





















    }
}


