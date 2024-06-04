using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        clsStock TestItem = new clsStock();

        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }

        }
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
            }
        

        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@OrderDate", mThisStock.OrderDate);
            DB.AddParameter("@Available", mThisStock.Available);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record to the database based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@OrderDate", mThisStock.OrderDate);
            DB.AddParameter("Available", mThisStock.Available);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");


        }

        public void Delete()
        {
            //delete the record pointed to by mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByItemName(string ItemName)
        {
            //filters the records based on a full or partial ItemName;
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send ItemName to the database
            DB.AddParameter("@ItemName", ItemName);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByItemName");
            //populate the array ist with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB

            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are no records to process
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                //read in fields from the current record
                AStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AStock.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add record to private data member
                mStockList.Add(AStock);
                //point at next record
                Index++;


            }
        }
    }
}
    





