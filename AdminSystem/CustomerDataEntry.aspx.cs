﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
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
            //capture the address id
            ACustomer.CustomerId = CustomerId;
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
            //capture email notification
            ACustomer.EmailNotification = chkEmailNotifications.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new recrd i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
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

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerId);
        //display the data for the record
        txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
        txtRegistrationDate.Text = CustomerBook.ThisCustomer.RegistrationDate.ToString();
        chkEmailNotifications.Checked = CustomerBook.ThisCustomer.EmailNotification;
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}

    

