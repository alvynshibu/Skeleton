using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtOrderLineId.Text) ||
         string.IsNullOrWhiteSpace(txtOrderId.Text) ||
         string.IsNullOrWhiteSpace(txtStockId.Text) ||
         string.IsNullOrWhiteSpace(txtQuantity.Text))
        {
            lblError.Text = "Please fill in all fields";
            return; // Exit the event handler
        }
        //create a new instanc of clsOrder
        clsOrderLine anOrderLine = new clsOrderLine();
        //capture order id
        anOrderLine.OrderLineId = Convert.ToInt32(txtOrderLineId.Text);
        anOrderLine.OrderId = Convert.ToInt32(txtOrderId.Text);
        anOrderLine.StockId = Convert.ToInt32(txtStockId.Text);
        anOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);

        //store address in session object
        Session["anOrderLine"] = anOrderLine;
        //Redirect
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Check if OrderLineId textbox is empty
        if (string.IsNullOrWhiteSpace(txtOrderLineId.Text))
        {
            lblError.Text = "Please enter OrderLine ID";
            return;
        }
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

        else
        {
            lblError.Text = "OrderLine ID not found";
        }
    }
}