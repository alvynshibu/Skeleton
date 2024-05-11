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

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Need to change below
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an insatnce of the orderline class
        clsOrderLine anOrderLine = new clsOrderLine();
        //create a variable to store the primary key
        Int32 OrderLineId;
        //variable to store result of find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderLineId = Convert.ToInt32(txtOrderLineId.Text);
        //find the record
        Found = anOrderLine.Find(OrderLineId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderLineId.Text = anOrderLine.OrderLineId.ToString();
            txtOrderId.Text = anOrderLine.OrderId.ToString();
            txtStockId.Text = anOrderLine.StockId.ToString();
            txtQuantity.Text = anOrderLine.Quantity.ToString();
            lblError.Text = "";
        }
        //fix null method
        if(txtOrderLineId.Text == null)
        {
            lblError.Text = "OrderLine ID is empty";
        }
        else
        {
            lblError.Text = "OrderLine ID not found";
        }
    }
}