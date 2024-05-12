using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrderLine
        clsOrderLine anOrderLine = new clsOrderLine();
        //get the dta from the session object
        anOrderLine = (clsOrderLine)Session["anOrderLine"];
        //display the address for this entry
        Response.Write(anOrderLine.OrderLineId);
        Response.Write(anOrderLine.OrderId);
        Response.Write(anOrderLine.StockId);
        Response.Write(anOrderLine.Quantity);
    }
}