using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        // Private data members for the Supplier properties
        private Int32 mSupplierId;
        private string mSupplierName;
        private string mSupplierEmail;
        private string mSupplierPhoneNumber;
        private string mSupplierAddress;
        private string mSupplierContactPerson;

        // Public properties for each private data member

        public Int32 SupplierId
        {
            get
            {
                return mSupplierId;
            }
            set
            {
                mSupplierId = value;
            }
        }

        public string SupplierName
        {
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }

        public string SupplierEmail
        {
            get
            {
                return mSupplierEmail;
            }
            set
            {
                mSupplierEmail = value;
            }
        }

        public string SupplierPhoneNumber
        {
            get
            {
                return mSupplierPhoneNumber;
            }
            set
            {
                mSupplierPhoneNumber = value;
            }
        }

        public string SupplierAddress
        {
            get
            {
                return mSupplierAddress;
            }
            set
            {
                mSupplierAddress = value;
            }
        }

        public string SupplierContactPerson
        {
            get
            {
                return mSupplierContactPerson;
            }
            set
            {
                mSupplierContactPerson = value;
            }
        }

        public bool Active { get; set; }

        // Find method to search for a supplier by SupplierId
        public bool Find(int supplierId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the supplier id to search for
            DB.AddParameter("@SupplierId", supplierId);
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");
            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["SupplierPhoneNumber"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mSupplierContactPerson = Convert.ToString(DB.DataTable.Rows[0]["SupplierContactPerson"]);
                // Return everything worked okay
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }

        // Validation method for supplier data
        public string Valid(string supplierName, string supplierAddress, string supplierEmail, string supplierPhoneNumber, string supplierContactPerson)
        {
            // Create a string variable to store the error
            String Error = "";

            // Validate supplier name
            if (supplierName.Length == 0)
            {
                Error = Error + "The supplier name may not be blank: ";
            }
            if (supplierName.Length > 100)
            {
                Error = Error + "The supplier name must be less than 30 characters: ";
            }

            // Validate supplier email
            if (supplierEmail.Length == 0)
            {
                Error = Error + "The supplier email may not be blank: ";
            }
            if (supplierEmail.Length > 100)
            {
                Error = Error + "The supplier email must be less than 45 characters: ";
            }

            // Validate supplier address
            if (supplierAddress.Length == 0)
            {
                Error = Error + "The supplier address may not be blank: ";
            }
            if (supplierAddress.Length > 255)
            {
                Error = Error + "The supplier address must be less than 255 characters: ";
            }

            // Validate supplier phone number
            if (supplierPhoneNumber.Length == 0)
            {
                Error = Error + "The supplier phone number may not be blank: ";
            }
            if (supplierPhoneNumber.Length > 20)
            {
                Error = Error + "The supplier phone number must be less than 15 characters: ";
            }

            // Validate supplier contact person
            if (supplierContactPerson.Length == 0)
            {
                Error = Error + "The supplier contact person may not be blank: ";
            }
            if (supplierContactPerson.Length > 100)
            {
                Error = Error + "The supplier contact person must be less than 50 characters: ";
            }

            // Return any error messages
            return Error;
        }
    }
}
