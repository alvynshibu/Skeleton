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

        public string Valid(string name, string dateOfBirth, string email, string address)
        {
            //create a string varibale to store the error
            String Error = "";

            //Cretae a temporay variable to store date values
            DateTime DateTemp;


            //if the name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank<br>";
            }

            if (name.Length > 50)
            {
                Error = Error + "The name character must be less than 50";
            }

            DateTime DateComp = DateTime.Now.Date;

            try
            {
               
                
                DateTemp = Convert.ToDateTime(dateOfBirth);

                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past";
                }

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch (FormatException)
            {
                Error = Error + "The date of birth is not vaild date.";
            }


            //if the email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank<br>";
            }

            if (email.Length > 50)
            {
                Error = Error + "The email character must be less than 50";
            }

            //if the address is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address may not be blank<br>";
            }

            if (address.Length > 50)
            {
                Error = Error + "The address character must be less than 50";
            }
            //return any error message
            return Error;
            
        }
    }
}