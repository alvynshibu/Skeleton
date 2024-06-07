using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff 
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtName.Text = StaffBook.ThisStaff.Name.ToString();
        txtDateOfBirth.Text = StaffBook.ThisStaff.DateOfBirth.ToString();
        txtEmail.Text = StaffBook.ThisStaff.Email.ToString();
        txtAddress.Text = StaffBook.ThisStaff.Address.ToString();
        chkNotification.Text = StaffBook.ThisStaff.Notification.ToString();

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
            //capture the staff id
            AnStaff.StaffId = StaffId;
            //capture the name
            AnStaff.Name = Name;
            AnStaff.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            AnStaff.Email = Email;
            AnStaff.Address = Address;
            AnStaff.Notification = chkNotification.Checked;
            //create a new instance of the address collection
            clsStaffCollection StaffList = new clsStaffCollection();
            
            //if this is a new record i.e StaffId = -1 then add the data
            if(StaffId == -1)
            {
                //set the ThisStaff proprty
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            else
            {
                //find the rceird to update
                StaffList.ThisStaff.Find(StaffId);
                //set the THISsTAFF proprtty
                StaffList.ThisStaff = AnStaff;
                //UPDATE the recird
                StaffList.Update();
            }

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

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
