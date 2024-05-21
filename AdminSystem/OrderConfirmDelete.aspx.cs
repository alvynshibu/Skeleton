using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable storing primary key to be deleted
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of order to be deleted from session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //instance of order collection classs
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find record to delete
        OrderBook.Delete();
        //redirect to orderlist page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //return to orderlist page
        Response.Redirect("OrderList.aspx");
    }
}