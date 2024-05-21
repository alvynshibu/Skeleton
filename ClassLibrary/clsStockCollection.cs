using System;
using System.Collections.Generic;
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
            RecordCount = DB.Count;
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

        public int Add()
        {
            mThisStock.StockId = 123;
            return mThisStock.StockId;
        }
    }
}






