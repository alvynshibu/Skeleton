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
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //gt the number of order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(OrderId != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click1(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsOrder anOrder = new clsOrder();
        //capture total amount
        decimal totalAmount;
        if (!string.IsNullOrWhiteSpace(txtTotalAmount.Text))
        {
            totalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        }
        else
        {
            totalAmount = (decimal)-0.01;
        }
        
        //capture customer id
        string customerId = txtCustomerId.Text;
        //capture the staff id
        string staffId = txtStaffId.Text;
        //capture delivery address
        string deliveryAddress = txtDeliveryAddress.Text;
        //capture date added
        string dateAdded = txtOrderDate.Text;
        //capture delivery status
        bool deliveryStatus = chkDeliveryStatus.Checked;
        //variable to store error messages
        String Error = "";

        Error = anOrder.Valid(customerId, deliveryAddress, dateAdded, totalAmount, staffId);
        if (Error == "")
        {
            //capture the order id
            anOrder.OrderId = OrderId;
            //capture total amount
            anOrder.TotalAmount = totalAmount;
            //capture delivery status
            anOrder.DeliveryStatus = deliveryStatus;
            //capture the Customer ID
            anOrder.CustomerId = Convert.ToInt32(customerId);
            //capture staffid
            anOrder.StaffId = Convert.ToInt32(staffId);
            //capture delivery address
            anOrder.DeliveryAddress = deliveryAddress;
            //capture date added
            anOrder.DateAdded = Convert.ToDateTime(dateAdded);
            //create instance of collection
            clsOrderCollection OrderList = new clsOrderCollection();
            //if this is a new record i.e. OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //set te thisorder property
                OrderList.ThisOrder = anOrder;
                //add new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //fnd the record to update
                OrderList.ThisOrder.Find(OrderId);
                //set the thisOrder property
                OrderList.ThisOrder = anOrder;
                //update record
                OrderList.Update();
            }
            //redirect to list page
            Response.Redirect("OrderList.aspx");

        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
       
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
            txtStaffId.Text = anOrder.StaffId.ToString();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Order ID not found";
        }

    }

    void DisplayOrder()
    {
        //instance of class
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record
        OrderBook.ThisOrder.Find(OrderId);
        //display test data
        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        txtDeliveryAddress.Text = OrderBook.ThisOrder.DeliveryAddress;
        txtOrderDate.Text = OrderBook.ThisOrder.DateAdded.ToString();
        chkDeliveryStatus.Checked = OrderBook.ThisOrder.DeliveryStatus;
        txtTotalAmount.Text = OrderBook.ThisOrder.TotalAmount.ToString();
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
    }

   
}