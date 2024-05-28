using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        //redirect user to order login page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        //redirect user to customer login page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockLogin.aspx");
    }
}