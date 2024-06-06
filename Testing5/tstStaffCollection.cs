using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffS = new clsStaffCollection();
            //test to see that is exist
            Assert.IsNotNull(AllStaffS);
        }

        [TestMethod]

        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set itd properties
            TestItem.StaffId = 1;
            TestItem.Name = "Sakib";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Email = "sakib@gmail.com";
            TestItem.Address = "Leicester";
            TestItem.Notification = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllStaffs.StaffList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        


        [TestMethod]

        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();

            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set itd properties
            TestStaff.StaffId = 1;
            TestStaff.Name = "Sakib";
            TestStaff.DateOfBirth = DateTime.Now;
            TestStaff.Email = "sakib@gmail.com";
            TestStaff.Address = "Leicester";
            TestStaff.Notification = true;
           
            //assign the data to the proprty
            AllStaffs.ThisStaff = TestStaff;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
                
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //create some test data to assign to the property

            //Add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set itd properties
            TestItem.StaffId = 1;
            TestItem.Name = "Sakib";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Email = "sakib@gmail.com";
            TestItem.Address = "Leicester";
            TestItem.Notification = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the proprty
            AllStaffs.StaffList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }

        [TestMethod]

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 1;
            TestItem.Name = "Sakib";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Email = "sakib@gmail.com";
            TestItem.Address = "Leicester";
            TestItem.Notification = true;
            
            //set ThisCustomer to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primay key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.  ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }

    }
}
