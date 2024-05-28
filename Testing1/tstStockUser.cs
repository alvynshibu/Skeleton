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
            clsStockUser AnUser = new clsStockUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Int32 TestData = 1;
            AnUser.UserId = TestData;
            Assert.AreEqual(AnUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "zia";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "zia123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStockUser AnUser = new clsStockUser();
            string TestData = "StockList";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            string UserName = "Zia";
            string Password = "Zia123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStockUser AnUser = new clsStockUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Zia";
            string Password = "Zia123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
