﻿using ClassLibrary;
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


        [TestMethod]

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 5;
            TestItem.Name = "Sakib";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Email = "sakib@gmail.com";
            TestItem.Address = "Leicester";
            TestItem.Notification = true;
          
            //set ThisCustomer to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.StaffId = 6;
            TestItem.Name = "mahajabin";
            TestItem.DateOfBirth = DateTime.Now;
            
            TestItem.Email = "ma@gamil.com";
            TestItem.Address = "London";
            TestItem.Notification = true;
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }



        [TestMethod]

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffId = 5;
            TestItem.Name = "Sakib";
            TestItem.DateOfBirth = DateTime.Now;
            TestItem.Email = "sakib@gmail.com";
            TestItem.Address = "Leicester";
            TestItem.Notification = true;
            //set ThisCustomer to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string
            FilteredStaffs.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]

        public void ReportByNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();

            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a name that doesn't exist
            FilteredStaffs.ReportByName("xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaffs.Count);
        }


        [TestMethod]

        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a customer email that doesn't exist
            FilteredStaffs.ReportByName("Sakib");
            //check that the corrext number of records are found
            if (FilteredStaffs.Count == 2)
            {
                //check to see that the first record is 1
                if (FilteredStaffs.StaffList[0].StaffId != 11)
                {
                    OK = false;
                }
                //check to see that the first record is 1
                if (FilteredStaffs.StaffList[1].StaffId != 30)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }


    }
}
