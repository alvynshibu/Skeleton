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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@StaffId", staffId);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mNotification = Convert.ToBoolean(DB.DataTable.Rows[0]["Notification"]);
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