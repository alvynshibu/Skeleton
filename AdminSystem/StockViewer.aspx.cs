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
        clsStock aStock = new clsStock();
        aStock = (clsStock)Session["aStock"];
        Response.Write(aStock.StockId);
        Response.Write(aStock.ItemName);
        Response.Write(aStock.Quantity);
        Response.Write(aStock.Price);
        Response.Write(aStock.SupplierId);
        Response.Write(aStock.Available);
        Response.Write(aStock.OrderDate);


    }

}