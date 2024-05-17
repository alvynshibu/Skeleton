using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create instance of order collection class
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of order in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set name of primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "DeliveryStatus";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    
    
}