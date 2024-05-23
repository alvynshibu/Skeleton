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
            StockId = Convert.ToInt32(lstStockList.SelectedIndex);
            Session["StockId"] = StockId;
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}

