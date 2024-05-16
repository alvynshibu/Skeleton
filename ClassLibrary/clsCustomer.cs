using System;
using System.Data.Common;
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
        private string mPhoneNumber;
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



        public string PhoneNumber
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
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
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

        public string Valid(string customerName, string customerAddress, string customerEmail, string phoneNumber, string registrationDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the CustomerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank  : ";
            }
            //if the customer name is greater than 30 characters
            if (customerName.Length > 30)
            {
                //record the error
                Error = Error + "The customer name must be less than 30 characters  : ";
            }
            try
            {
                //copy the registrationDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(registrationDate);

                //check to see if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past  : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future  : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date  :";
            }

            //if the CustomerEmail is blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The customer email may not be blank  : ";
            }

            //if the customer email is too long
            if (customerEmail.Length > 45)
            { 
                //record the error
                Error = Error + "The customer email must be less than 45 characters  : ";
            }

            //if the customer address is blank
            if (customerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customer address may not be blank  : ";
            }

            //if the customer address is too long
            if (customerAddress.Length > 255)
            {
                //record the error
                Error = Error + "The customer address must be less than 300 characters  : ";
            }

            //if the phone number is blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank";
            }

            //if the phone number is too long
            if (phoneNumber.Length > 15)
            {
                //record the error
                Error = Error + "The phone number must be less than 15 characters  : ";
            }


            //return any error messages
            return Error;
        }





    }

}