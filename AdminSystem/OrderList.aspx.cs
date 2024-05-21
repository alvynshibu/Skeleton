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




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect the entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary key value of the record
        Int32 OrderId;
        //if a record has been selected from the list
        if(lstOrderList.SelectedIndex != -1)
        {
            //get primary key of record to edit
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store data in session
            Session["OrderId"] = OrderId;
            //redirect to edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        //if no record has been selected
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}