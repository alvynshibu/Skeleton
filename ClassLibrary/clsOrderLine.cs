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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the orderline id to search for
            DB.AddParameter("@OrderLineId", orderLineId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //set private data members to test data value
                mOrderLineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //always return true
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