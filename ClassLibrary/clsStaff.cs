using System;

namespace ClassLibrary
{



    public class clsStaff
    {
        //private data member for the address id propert
        private Int32 mStaffId;
        //private data member for the name property
        private string mName;
        //private data member for the DateOfBirth
        private DateTime mDateOfBirth;
        //private data member for the name property
        private string mEmail;
        //private data member for the name property
        private string mAddress;
        //private data member for the Notification property
        private Boolean mNotification;




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




        public bool Notification
        {
            get
            {
                //this line of code sends data out of the property
                return Notification;
            }
            set
            {
                //this line of code allows data into the property
                mNotification = value;
            }
        }


        public bool Find(int StaffId)
        {
            //create an instance of the data data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_TblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mNotification = Convert.ToBoolean(DB.DataTable.Rows[0]["Notification"]);
                //return that everything worked OK
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