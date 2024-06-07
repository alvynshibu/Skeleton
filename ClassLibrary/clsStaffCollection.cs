using System;
using System.Collections.Generic;
using System.Data.Common;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data memebr for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList 
        { 
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count 
        { 
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }

        
        }
        public clsStaff ThisStaff 
        { 
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        //Constructor for the clas

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;

            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stores procedure
            DB.Execute("sproc_TblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            {
             //create a blank Staff
             clsStaff AnStaff = new clsStaff();
                //read in the fields for the current record
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Notification = Convert.ToBoolean(DB.DataTable.Rows[Index]["Notification"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a record to the database based on the valued of mthis staff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Notification", mThisStaff.Notification);

            //execute the query returning the primary key value
            return DB.Execute("sproc_TblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on te values of ThisCustomer
            //connetc to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@DateOfBirth", mThisStaff.DateOfBirth);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Notification", mThisStaff.Notification);
       
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_Update");
        }
    }
}