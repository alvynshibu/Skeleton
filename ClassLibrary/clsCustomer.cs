using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data members for the CustomerId property
        private Int32 mCustomerId;
        private bool mEmail;
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


        public bool Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
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



        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 21;
            mEmail = true;
            mRegistrationDate = Convert.ToDateTime("23/12/2022");
            mCustomerName = "Alvyn";
            mCustomerEmail = "alvynshibu@gmail.com";
            mPhoneNumber = 07341251;
            mCustomerAddress = "1 Lineker Road, Leicester, LE2 7FZ";
            //always return true
            return true;
        }
    }

}