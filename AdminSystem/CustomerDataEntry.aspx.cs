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
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the registration date
        string RegistrationDate = txtRegistrationDate.Text;
        //capture the email notifications
        string EmailNotification = chkEmailNotifications.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerEmail, PhoneNumber, RegistrationDate);
        if (Error == "")
        {
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the phone number
            ACustomer.PhoneNumber = PhoneNumber;
            //capture the registration date
            ACustomer.RegistrationDate = Convert.ToDateTime(RegistrationDate);
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //Navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    

