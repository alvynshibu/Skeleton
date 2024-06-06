using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockId = Convert.ToInt32(Session["StockId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (StockId != -1)
            {
                //display the current data for the record
                DisplayStocks();
            }
            else
            {
                txtStockId.Text = StockId.ToString();
                txtStockId.Enabled = false;
                btnFind.Enabled = false;
            }
        }
    }

    void DisplayStocks()
    {
        //create an instance of the stock book
        clsStockCollection Stocklist = new clsStockCollection();
        //find the record to update
        Stocklist.ThisStock.Find(StockId);
        //display the data for the record
        txtStockId.Text = Stocklist.ThisStock.StockId.ToString();
        txtItemName.Text = Stocklist.ThisStock.ItemName;
        txtQuantity.Text = Stocklist.ThisStock.Quantity.ToString();
        txtPrice.Text = Stocklist.ThisStock.Price.ToString();
        txtSupplierId.Text = Stocklist.ThisStock.SupplierId.ToString();
        txtOrder.Text = Stocklist.ThisStock.OrderDate.ToString();
        chkAvailable.Text = Stocklist.ThisStock.Available.ToString();
    }





    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        //capture the ItemName
        string ItemName = txtItemName.Text;
        //capture the Quantity
        string Quantity = txtQuantity.Text;
        //capture the price
        string Price = txtPrice.Text;
        //capture the supplierId
        string SupplierId = txtSupplierId.Text;
        //capture the Available
        string Available = chkAvailable.Text;
        //capture the OrderDate
        string OrderDate = txtOrder.Text;
        //validate the data
        string Error = "";
        Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
        if (Error == "")
        {
            //capture the StockId
            aStock.StockId = StockId;
            //capture the itemName
            aStock.ItemName = ItemName;
            //capture the Quantity
            aStock.Quantity = Convert.ToInt32(Quantity);
            //capture the price
            aStock.Price = Convert.ToDecimal(Price);
            //capture the supplierId
            aStock.SupplierId = Convert.ToInt32(SupplierId);
            //capture the Available
            aStock.Available = Convert.ToBoolean(Available);
            //capture the OrderDate
            aStock.OrderDate = Convert.ToDateTime(OrderDate);
            clsStockCollection StockList = new clsStockCollection();
            if (StockId == -1)
            {
                StockList.ThisStock = aStock;
                StockList.Add();
            }
            else
            {
                //find the record to update
                StockList.ThisStock.Find(StockId);
                //set the ThisCustomer property
                StockList.ThisStock = aStock;
                //update the record
                StockList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock aStock = new clsStock();
        //create a variable to store the primary key
        Int32 StockId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockId = Convert.ToInt32(txtStockId.Text);
        //find the record
        Found = aStock.Find(StockId);
        //if found
        if (Found == true) {
        //display the values of the properties in the form
        txtItemName.Text = aStock.ItemName;
            txtQuantity.Text = aStock.Quantity.ToString();
            txtPrice.Text = aStock.Price.ToString();
            txtSupplierId.Text = aStock.SupplierId.ToString(); 
            chkAvailable.Text = aStock.Available.ToString();
            txtOrder.Text = aStock.OrderDate.ToString();
        }

    

    }







    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}