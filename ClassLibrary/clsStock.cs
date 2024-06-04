using System;
using System.Diagnostics.SymbolStore;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the Stock id property
        private Int32 mStockId;

        private string mItemName;
        //private data member for quantity property
        private int mQuantity;
        //private data member for price property
        private decimal mPrice;
        //private data member for supplierid property
        private int mSupplierId;
        //private data member for available property
        private bool mAvailable;
        //private data member for date added property
        private DateTime mOrderDate;

        //StockId public property
        public Int32 StockId
        {
            get
            {
                //return line of code sends data out of the property
                return mStockId;
            }
            set
            {
                //this line of code allows data into the property
                mStockId = value;
            }
        }


        public string ItemName
        {
            get
            {
                //return line of code sends data out of the property
                return mItemName;
            }
            //this line of code allows data into the property
            set { mItemName = value; }
        }

        public int Quantity
        {
            get
            {
                //return line of code sends data out of the property
                return mQuantity;
            }
            //this line of code allows data into the property
            set { mQuantity = value; }
        }

        public decimal Price
        {
            get
            {
                //return line of code sends data out of the property
                return mPrice;
            }
            //this line of code allows data into the property
            set { mPrice = value; }
        }

        public int SupplierId
        {
            get
            {
                //return line of code sends data out of the property
                return mSupplierId;
            }
            //this line of code allows data into the property
            set { mSupplierId = value; }
        }

        public bool Available
        {
            get
            {
                //return line of code sends data out of the property
                return mAvailable;
            }
            //this line of code allows data into the property
            set { mAvailable = value; }
        }

        public DateTime OrderDate
        {
            get
            {
                //return line of code sends data out of the property
                return mOrderDate;
            }
            //this line of code allows data into the property
            set { mOrderDate = value; }
        }





        public bool Find(int stockId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@StockId", stockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }


        }

        public string Valid(string itemName, string quantity, string price, string supplierId, string available, string orderDate)
        {
            String Error = "";
            DateTime DateTemp;
            //if the HouseNo is blank
            if (itemName.Length == 0)
            {
                //record the error
                Error = Error + "The ItemName name may not be blank :";
            }
            //if the ItemName is greater than 5 characters
            if (itemName.Length > 30)
            {
                Error = Error + "The ItemName must not be less than 5 characters:";
            }

            if (quantity.Length == 0)
            {
                Error = Error + "The Quantity may not be empty ";
            }
           else if (!int.TryParse(quantity, out int quantityValue) || quantityValue<=0) 
            {
                Error = Error + "The Quantity must be greater than 1";            
            }

            if (price.Length == 0)
            {
                Error = Error + "The Price may not be empty ";
            }
            else if (!decimal.TryParse(price, out decimal priceValue) || priceValue <= 0)
            {
                Error = Error + "The Price must be greater than 1";
            }
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in future";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date";
            }



            //return any error messages
            return Error;
        }

 
    }
}
