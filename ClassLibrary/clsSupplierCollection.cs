using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private member data for thisSupplier
        clsSupplier mThisSupplier = new clsSupplier();

        //public property for the supplier list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set the private data
                mThisSupplier = value;
            }
        }

        //constructor for the class
        public clsSupplierCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@ContactPerson", mThisSupplier.SupplierContactPerson);
            DB.AddParameter("@PhoneNumber", mThisSupplier.SupplierPhoneNumber);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@ContactPerson", mThisSupplier.SupplierContactPerson);
            DB.AddParameter("@PhoneNumber", mThisSupplier.SupplierPhoneNumber);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters the records based on a full or partial supplier name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the supplier name parameter to the database
            DB.AddParameter("@SupplierName", SupplierName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank supplier
                clsSupplier ASupplier = new clsSupplier();
                //read in the fields for the current record
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                ASupplier.SupplierContactPerson = Convert.ToString(DB.DataTable.Rows[Index]["ContactPerson"]);
                ASupplier.SupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                ASupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }
    }
}

