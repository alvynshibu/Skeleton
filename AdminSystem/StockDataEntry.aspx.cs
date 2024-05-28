using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockId = Convert.ToInt32(Session["StockId"]);
        if (IsPostBack == false)
        {
            if (StockId != -1)
            {
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stocklist = new clsStockCollection();

        Stocklist.ThisStock.Find(StockId);
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
        clsStock aStock = new clsStock();
        string ItemName = txtItemName.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string SupplierId = txtSupplierId.Text;
        string Available = chkAvailable.Text;
        string OrderDate = txtOrder.Text;
        string Error = "";
        Error = aStock.Valid(ItemName, Quantity, Price, SupplierId, Available, OrderDate);
        if (Error == "")
        {
            aStock.StockId = StockId;
            aStock.ItemName = ItemName;
            aStock.Quantity = Convert.ToInt32(Quantity);
            aStock.Price = Convert.ToDecimal(Price);
            aStock.SupplierId = Convert.ToInt32(SupplierId);
            aStock.Available = Convert.ToBoolean(Available);
            aStock.OrderDate = Convert.ToDateTime(OrderDate);
            clsStockCollection StockList = new clsStockCollection();
            if (StockId == -1)
            {
                StockList.ThisStock = aStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockId);
                StockList.ThisStock = aStock;
                StockList.Update();
            }
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
        Response.Redirect("TeamMainMenu.apx");
    }
}