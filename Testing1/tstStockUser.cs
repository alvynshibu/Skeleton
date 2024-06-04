using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            //isntance of class
            clsStockUser AnUser = new clsStockUser();
            //test data 
            Int32 TestData = 1;
            //assign test data to property
            AnUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "zia";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "zia123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockUser AnUser = new clsStockUser();
            //create some test data to assign to the property
            string TestData = "StockList";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //instance of class 
            clsStockUser AnUser = new clsStockUser();
            //boolean to store result of validation
            Boolean Found = false;
            //test data
            string UserName = "Zia";
            string Password = "Zia123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            //test result
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //instance of class
            clsStockUser AnUser = new clsStockUser();
            //boolean to store result of validation
            Boolean Found = false;
            //boolean varaible to record if data is OK
            Boolean OK = true;
            //test data
            string UserName = "Zia";
            string Password = "Zia123";
            //invoke method
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test result
            Assert.IsTrue(OK);
        }

    }
}
