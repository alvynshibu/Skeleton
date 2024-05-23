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
        //private data member for the order id property
        private Int32 mStaffId;
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
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        public bool Find(int orderId)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the order id to search for
            DB.AddParameter("@OrderId", orderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mDeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["DeliveryStatus"]);
                mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating problem
                return false;
            }

        }

        public string Valid(string customerId, string deliveryAddress, string dateAdded, decimal totalAmount, string staffId)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the delivery address is blank
            if(deliveryAddress.Length == 0)
            {
                Error = Error + "The delivery address cannot be blank : ";
            }
            if (deliveryAddress.Length > 100)
            {
                Error = Error + "The delivery address is too long : ";
            }
            //create an instance of DateTime to compare with DateTemp in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                //compare dateadded wih date
                if(DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if(DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }
            //if total amount is less than 0
            if(totalAmount < (decimal)0.00 || totalAmount == null)
            {
                Error = Error + "The total price cannot be less than 0 : ";
            }
            //if the customer id is blank
            if(customerId.Length == 0)
            {
                Error = Error + "Customer ID cannot be blank : ";
            }
            //if the staff id is blank
            if (staffId.Length == 0)
            {
                Error = Error + "Staff ID cannot be blank : ";
            }
            

            //return any error messages
            return Error;
        }
    }
}