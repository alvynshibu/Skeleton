using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data members for the CustomerId property
        private Int32 mCustomerId;
        private bool mEmailNotification;
        private DateTime mRegistrationDate;
        private string mCustomerName;
        private string mCustomerEmail;
        private Int32 mPhoneNumber;
        private string mCustomerAddress;


        public Int32 CustomerId
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


        public bool EmailNotification
        {
            get
            {
                //this line of code sends data out of the property
                return mEmailNotification;
            }
            set
            {
                //this line of code allows data into the property
                mEmailNotification = value;
            }
        }


        public DateTime RegistrationDate
        {
            get
            {
                //this line of code sends data out of the property
                return mRegistrationDate;
            }
            set
            {
                //this line of code allows data into the property
                mRegistrationDate = value;
            }
        }



        public string CustomerName
        {
            get
            { 
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }



        public string CustomerEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }



        public Int32 PhoneNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mPhoneNumber;
            }
            set
            {
                //this line of code allows data into the property
                mPhoneNumber = value;
            }
        }



        public string CustomerAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }

        /****** FIND METHOD ******/

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mRegistrationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegistrationDate"]);
                mEmailNotification = Convert.ToBoolean(DB.DataTable.Rows[0]["EmailNotification"]);
                //return everything that worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false, indicating there is a problem
                return false;
            }
        }
    }

}