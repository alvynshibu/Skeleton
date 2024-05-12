using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtOrderId.Text) ||
         string.IsNullOrWhiteSpace(txtCustomerId.Text) ||
         string.IsNullOrWhiteSpace(txtDeliveryAddress.Text) ||
         string.IsNullOrWhiteSpace(txtOrderDate.Text) ||
         string.IsNullOrWhiteSpace(txtTotalAmount.Text))
        {
            lblError.Text = "Please fill in all fields";
            return;
        }
        //create a new instance of clsOrder
        clsOrder anOrder = new clsOrder();
        //capture order id
        anOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        anOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        anOrder.DeliveryAddress = txtDeliveryAddress.Text;
        anOrder.DateAdded = Convert.ToDateTime(txtOrderDate.Text);
        anOrder.DeliveryStatus = chkDeliveryStatus.Checked;
        anOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        //store address in session object
        Session["anOrder"] = anOrder;

        //navigate to view page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Check if OrderId textbox is empty
        if (string.IsNullOrWhiteSpace(txtOrderId.Text))
        {
            lblError.Text = "Please enter Order ID";
            return;
        }
        //create an insatnce of the order class
        clsOrder anOrder = new clsOrder();
        //create a variable to store the primary key
        Int32 OrderId;
        //variable to store result of find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = anOrder.Find(OrderId);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtCustomerId.Text = anOrder.CustomerId.ToString();
            txtDeliveryAddress.Text = anOrder.DeliveryAddress;
            txtOrderDate.Text = anOrder.DateAdded.ToString();
            chkDeliveryStatus.Checked = anOrder.DeliveryStatus;
            txtTotalAmount.Text = anOrder.TotalAmount.ToString();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Order ID not found";
        }

    }
}