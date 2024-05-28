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

        clsStockUser AnUser = new clsStockUser();
        //get data from the session objct
        AnUser = (clsStockUser)Session["AnUser"];
        //display the user name
        Response.Write("Logged in as:" + AnUser.UserName);

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
        Session["StockId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockId;
        if (lstStockList.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockId;
        if (lstStockList.SelectedIndex != -1)
        {
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockId"] = StockId;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }



    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByItemName(txtFilter.Text);
        lstStockList.DataSource = aStock.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByItemName("");
        txtFilter.Text = "";
        lstStockList.DataSource= aStock.StockList;
        lstStockList.DataValueField = "StockId";
        lstStockList.DataValueField = "ItemName";
        lstStockList.DataBind();
    }



    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}

