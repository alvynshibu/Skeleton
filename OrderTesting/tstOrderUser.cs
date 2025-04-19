using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsOrderUser aUser = new clsOrderUser();
            //test to see that it exists
            Assert.IsNotNull(aUser);
        }

        [TestMethod]

        public void UserIdPropertyOk()
        {
            //isntance of class
            clsOrderUser aUser = new clsOrderUser();
            //test data 
            Int32 TestData = 1;
            //assign test data to property
            aUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Leo";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Leo123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderUser AnUser = new clsOrderUser();
            //create some test data to assign to the property
            string TestData = "Order";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FinsUserMethodOk()
        {
            //instance of class 
            clsOrderUser aUser = new clsOrderUser();
            //boolean to store result of validation
            Boolean Found = false;
            //test data
            string Username = "Leo";
            string Password = "Leo123";
            //invoke method
            Found = aUser.FindUser(Username, Password);
            //test result
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            //instance of class
            clsOrderUser aUser = new clsOrderUser();
            //boolean to store result of validation
            Boolean Found = false;
            //boolean varaible to record if data is OK
            Boolean OK = true;
            //test data
            string Username = "Leo";
            string Password = "Leo123";
            //invoke method
            Found = aUser.FindUser(Username, Password);
            if(aUser.UserName != Username && aUser.Password != Password)
            {
                OK = false;
            }
            //test result
            Assert.IsTrue(Found);
        }
    }
}
