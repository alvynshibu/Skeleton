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
        ACustomer.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
        ACustomer.RegistrationDate = Convert.ToDateTime(DateTime.Now);
        ACustomer.Email = chkEmailNotifications.Checked;

        //store the attributes in the sesion object
        Session["ACustomer"] = ACustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}

    

