using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //test to see that it exists
            Assert.IsNotNull(aUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create some test data to assign to the property
            Int32 TestData = 42;
            //assign the data to the property
            aUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "RandomUser";
            //assign the data to the property
            aUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "RandomPassword123";
            //assign the data to the property
            aUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create some test data to assign to the property
            string TestData = "Supplier";
            //assign the data to the property
            aUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOk()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "RandomUser";
            string Password = "RandomPassword123";
            //invoke the method
            Found = aUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsSupplierUser aUser = new clsSupplierUser();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "RandomUser";
            string Password = "RandomPassword123";
            //invoke the method
            Found = aUser.FindUser(UserName, Password);
            //check the user id property
            if (aUser.UserName != UserName || aUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
