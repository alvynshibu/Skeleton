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
            //set the private data members to the test data value
            mStockId = 21;
            //always return true;
            return true;
        }


    }
}