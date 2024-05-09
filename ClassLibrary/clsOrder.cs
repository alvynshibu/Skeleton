using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;
        //private data member for date added property
        private DateTime mDateAdded;
        //private data member for customer id property
        private Int32 mCustomerId;
        //private data member for delivery address property
        private String mDeliveryAddress;
        //private data member for total amount property
        private decimal mTotalAmount;
        //private data member for delivery status property
        private Boolean mDeliveryStatus;
        //orderid public property
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        public bool DeliveryStatus
        {
            get
            {
                //this line of code sends a data out of the property
                return mDeliveryStatus;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryStatus = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends a data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        public string DeliveryAddress
        {
            get
            {
                //this line of code sends a data out of the property
                return mDeliveryAddress;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryAddress = value;
            }
        }
        public decimal TotalAmount
        {
            get
            {
                //this line of code sends a data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }

        public bool Find(int orderId)
        {
            //placeholder test
            mOrderId = 21;
            mCustomerId = 21;
            mDeliveryAddress = "LE3 000";
            mDeliveryStatus = true;
            mTotalAmount = (decimal)200.50;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            //always return true
            return true;
        }
    }
}