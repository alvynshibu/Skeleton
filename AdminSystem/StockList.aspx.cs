using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        //create instance of order collection class
        clsStockCollection Stocks = new clsStockCollection();
        //set the data source to list of order in the collection
        lstStockList.DataSource = Stocks.StockList;
        //set name of primary key
        lstStockList.DataValueField = "StockId";
        //set the data field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StockId;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //redirect to the delete page
            Session["StockId"] = StockId;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }



    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection aStock = new clsStockCollection();
        //retrieve the value of post code from the presentation layer
        aStock.ReportByItemName(txtFilter.Text);
        //set the data source to the list of stock in the collection
        lstStockList.DataSource = aStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the name of the field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the stock object
        clsStockCollection aStock = new clsStockCollection();
        //set an empty string
        aStock.ReportByItemName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of stocks in the collection
        lstStockList.DataSource= aStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the name of the field to display
        lstStockList.DataValueField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }


    protected void btnMainMenu_Click1(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}

