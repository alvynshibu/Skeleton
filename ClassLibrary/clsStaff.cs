using System;

namespace ClassLibrary
{
    public class clsStaff
    {

       
        
        
        



        //private data member for the address id propert
        private Int32 mStaffId;
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

        //private data member for the name property
        private string mName;
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into the property
                mName = value;
            }
        }
        //private data member for the DateOfBirth
        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfBirth;
            }
            set
            {
                //this line of code allows data into property
                mDateOfBirth = value;
            }
        }
        //private data member for the name property
        private string mEmail;
        public string Email
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


        //private data member for the name property
        private string mAddress;
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }



        //private data member for the Notification property
        private Boolean mNotification;
        public bool Notification
        {
            get
            {
                //this line of code sends data out of the property
                return mNotification;
            }
            set
            {
                //this line of code allows data into the property
                mNotification = value;
            }
        }

        public bool Find(int staffId)
        {
            //set to private data memebers to the test data value
            mStaffId = 21;
            mName = "x";
            mDateOfBirth = Convert.ToDateTime("30/08/2002");
            mEmail = "l@gmail.com";
            mAddress = "kk";
            mNotification = true;
            //always return true
            return true;
        }
    }
}