using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private int mUserId;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserId
        {
            get
            {
                //return user id
                return mUserId;
            }
            set
            {
                //set private data
                mUserId = value;
            }
        }
        public string UserName
        {
            get
            {
                //return username
                return mUserName;
            }
            set
            {
                //set private data
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                //return password
                return mPassword;
            }
            set
            {
                //set private data
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                //return department
                return mDepartment;
            }
            set
            {
                //set private data
                mDepartment = value;
            }
        }

        public bool FindUser(string username, string password)
        {
            //instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters
            DB.AddParameter("@UserName", username);
            DB.AddParameter("@Password", password);
            //execute stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found
            if(DB.Count == 1)
            {
                //copy data from db to priovate date member
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}