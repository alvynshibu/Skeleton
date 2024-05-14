using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the address id property
        private Int32 mStockId;
        private string mItemName;
        private int mQuantity;
        private decimal mPrice;
        private int mSupplierId;
        private bool mAvailable;
        private DateTime mOrderDate;

        //StockId public property
        public Int32 StockId
        {
            get
            {
                //return line of code sends data out of the property
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }


        public string ItemName
        {
            get
            {
                return mItemName;
            }
            set { mItemName = value; }
        }

        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set { mQuantity = value; }
        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set { mPrice = value; }
        }

        public int SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set { mSupplierId = value; }
        }

        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set { mAvailable = value; }
        }

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set { mOrderDate = value; }
        }





        public bool Find(int stockId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StockId", stockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }


        }
    }
}
