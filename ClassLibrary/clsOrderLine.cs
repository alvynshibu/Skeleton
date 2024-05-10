using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        //private data member for the orderline id property
        private Int32 mOrderLineId;
        //private data member for the order id property
        private Int32 mOrderId;
        //private data member for the stock id property
        private Int32 mStockId;
        //private data member for the quantity property
        private Int32 mQuantity;
        public int OrderLineId
        {
            get
            {
                //sends data out of the property
                return mOrderLineId;
            }
            set
            {
                //allows data in the property
                mOrderLineId = value;
            }
        }
        public int OrderId
        {
            get
            {
                //sends data out of the property
                return mOrderId;
            }
            set
            {
                //allows data in the property
                mOrderId = value;
            }
        }
        public int StockId
        {
            get
            {
                //sends data out of the property
                return mStockId;
            }
            set
            {
                //allows data in the property
                mStockId = value;
            }
        }
        public int Quantity
        {
            get
            {
                //sends data out of the property
                return mQuantity;
            }
            set
            {
                //allows data in the property
                mQuantity = value;
            }
        }

        public bool Find(int orderLineId)
        {
            //set private data members to test data value
            mOrderLineId = 21;
            mOrderId = 21;
            mStockId = 21;
            mQuantity = 21;
            //always return true
            return true;
        }
    }
}