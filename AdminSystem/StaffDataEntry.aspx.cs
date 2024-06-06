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

        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Name
        string Name = txtName.Text;
        //capture the date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture the notification
        string Notification = chkNotification.Text;
        //varibale tom store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(Name, DateOfBirth, Email, Address);
        if (Error == "")
        {
            //capture the name
            AnStaff.Name = Name;
            AnStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnStaff.Email = Email;
            AnStaff.Address = Address;
            AnStaff.Notification = chkNotification.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the thistaff proprty
            StaffList.ThisStaff = AnStaff;
            //add new record
            StaffList.Add();
            //navigate to the view page
            Response.Redirect("StaffList.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;
        }

        





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
