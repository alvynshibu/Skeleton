using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for this address
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //complete later
            }
        }
        //public property for thisOrder
        public clsOrder ThisOrder
        {
            //return the private data
            get
            {
                return mThisOrder;
            }
            //set the private data member
            set
            {
                mThisOrder = value;
            }
        }

        //costructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //eecute stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //popuate array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a record to the database based on the value of mThisOrder
            //set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@OrderDate", mThisOrder.DateAdded);
            DB.AddParameter("@DeliveryStatus", mThisOrder.DeliveryStatus);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //updates ecisting record based on OrderId
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the new stored proceure
            DB.AddParameter("@Orderid", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@DeliveryAddress", mThisOrder.DeliveryAddress);
            DB.AddParameter("@OrderDate", mThisOrder.DateAdded);
            DB.AddParameter("@DeliveryStatus", mThisOrder.DeliveryStatus);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute stored procdure
            DB.Execute("sproc_tblOrder_delete");
        }

        public void ReportByDeliveryAddress(string DeliveryAddress)
        {
            //filters the records based on a full or partial delivery address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send address to the database
            DB.AddParameter("@DeliveryAddress", DeliveryAddress);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByDeliveryAddress");
            //populate the array ist with the data table
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
            mOrderList = new List<clsOrder>();
            //while there are no records to process
            while(Index < RecordCount)
            {
                //create a blank address object
                clsOrder anOrder = new clsOrder();
                //read in fields from the current record
                anOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                anOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                anOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                anOrder.DeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["DeliveryStatus"]);
                anOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                anOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                anOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                //add record to private data member
                mOrderList.Add(anOrder);
                //point at next record
                Index++;
            }
        }


    }
}