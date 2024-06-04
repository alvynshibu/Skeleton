using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        StockId = Convert.ToInt32(Session["StockId"]);

    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer collection class
        clsStockCollection StockList = new clsStockCollection();
        //find the record to delete
        StockList.ThisStock.Find(StockId);
        //delete the record
        StockList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }





    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}