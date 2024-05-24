using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        //create some test data to pass the method
        string DeliveryAddress = "LE3 000";
        string DateAdded = DateTime.Now.ToShortDateString();
        string CustomerId = "2";
        string StaffId = "2";
        decimal totalAmount = (decimal)200.02;


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

            Int32 TestData = 5;

            anOrder.OrderId = TestData;

            Assert.AreEqual(anOrder.OrderId, TestData);
        }

        [TestMethod]

        public void DeliveryStatusOK()
        {
            clsOrder anOrder = new clsOrder();

            Boolean TestData = Convert.ToBoolean(1);

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


            anOrder.TotalAmount = (decimal)20.00;

            Assert.AreEqual(anOrder.TotalAmount, (decimal)20.00);
        }
        
        [TestMethod]

        public void StaffIdOK()
        {
            clsOrder anOrder = new clsOrder();

            Int32 TestData = 1;

            anOrder.StaffId = TestData;

            Assert.AreEqual(anOrder.StaffId, TestData);
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
            Int32 OrderId = 2;
            //invoke the method
            Found = anOrder.Find(OrderId);
            //check the date added property
            if (anOrder.DateAdded != Convert.ToDateTime("2024-05-02"))
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
        
        [TestMethod]

        public void TestStaffIdFound()
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
            //check the staff id
            if (anOrder.StaffId != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store an error message
            string Error = "";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressMinMinusOne()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void DeliveryAddressMin()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "L";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressMinPlusOne()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "LE";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressMaxPlusOne()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(101, 'a');
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressMaxMinusOne()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(99, 'a');
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressMid()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(50, 'a');
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DeliveryAddressExtremeMax()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(500, 'a');
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {
            //create an instance of the class
            clsOrder anOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays  date
            TestDate = DateTime.Now.Date;
            //change the date to todays date - 100 years
            TestDate = TestDate.AddYears(-100);
            //create some test data to pass to the method
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]

        public void DateAddedMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non data value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIdMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string CustomerId = "";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIdMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string CustomerId = "1";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string CustomerId = "12";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffIdMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string StaffId = "";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffIdMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string StaffId = "1";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            string StaffId = "12";
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void TotalAmountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            decimal totalAmount = (decimal)0.01;
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]

        public void TotalAmountMinMinusOne()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            decimal totalAmount = (decimal)-0.01;
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]

        public void TotalAmountMin()
        {
            //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            decimal totalAmount = (decimal)0.00;
            //invoke the method
            Error = anOrder.Valid(CustomerId, DeliveryAddress, DateAdded, totalAmount, StaffId);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
