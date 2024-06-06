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

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsStaff AnStaff = new clsStaff();

        AnStaff.Name = txtName.Text;
        Session["AnStaff"] = AnStaff;
        //navigate to the view page


        Response.Redirect("StaffViewer.aspx");

        //capture the notificaion
        AnStaff.Notification=chkNotification.Checked;
        ;

        //capture the Date Added
        AnStaff.DateOfBirth = Convert.ToDateTime(DateTime.Now);
       

        //Email
        AnStaff.Email = txtEmail.Text;
       



        //Address
        AnStaff.Address = txtAddress.Text;
        


        Response.Redirect("StaffViewer.aspx");





    }

    protected void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //cretae an instance of the address class
        clsStaff AnStaff = new clsStaff();
        //create an varibale to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key enetered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtName.Text = AnStaff.Name;
            txtDateOfBirth.Text = AnStaff.DateOfBirth.ToString();
            txtEmail.Text = AnStaff.Email;
            txtAddress.Text = AnStaff.Address;
            chkNotification.Checked = AnStaff.Notification;

        }

    }
}
