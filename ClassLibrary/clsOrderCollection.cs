using System;
using System.Collections.Generic;

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
            //variable for index
            Int32 Index = 0;
            //variable to store record count
            Int32 recordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get count of records
            recordCount = DB.Count;
            //while there are records to process
            while (Index < recordCount)
            {
                //create a blank order
                clsOrder anOrder = new clsOrder();
                //read in the fields for the current record
                anOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                anOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                anOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                anOrder.DeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["DeliveryStatus"]);
                anOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddress"]);
                anOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                anOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                //add record to private data member
                mOrderList.Add(anOrder);
                //point at the next record
                Index++;
            }
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
    }
}