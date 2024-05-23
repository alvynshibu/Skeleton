using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }

        void DisplayStocks()
        {
            clsStockCollection aStock = new clsStockCollection();
            lstStockList.DataSource = aStock.StockList;
            lstStockList.DataValueField = "StockId";
            lstStockList.DataTextField = "ItemName";
            lstStockList.DataBind();
        }





    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}

