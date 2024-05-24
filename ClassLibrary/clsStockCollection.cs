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
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@OrderDate", mThisStock.OrderDate);
            DB.AddParameter("@Available", mThisStock.Available);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@SupplierId", mThisStock.SupplierId);
            DB.AddParameter("@OrderDate", mThisStock.OrderDate);
            DB.AddParameter("Available", mThisStock.Available);
            DB.Execute("sproc_tblStock_Update");


        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByItemName(string ItemName)
        {
            //filters the records based on a full or partial ItemName;
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemName", ItemName);
            DB.Execute("sproc_tblStock_FilterByItemName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB

            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AStock.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                mStockList.Add(AStock);
                Index++;


            }
        }
    }
}
    





