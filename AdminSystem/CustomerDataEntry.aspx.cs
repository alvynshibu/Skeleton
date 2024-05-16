using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        {
           
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the attributes
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        ACustomer.PhoneNumber = txtPhoneNumber.Text;
        ACustomer.RegistrationDate = Convert.ToDateTime(DateTime.Now);
        ACustomer.EmailNotification = chkEmailNotifications.Checked;

        //store the attributes in the sesion object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer ACustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtPhoneNumber.Text = ACustomer.PhoneNumber;
            txtRegistrationDate.Text = ACustomer.RegistrationDate.ToString();
            chkEmailNotifications.Checked = ACustomer.EmailNotification;
        }
    }
}

    

