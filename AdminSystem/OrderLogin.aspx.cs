using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //isntance of class
        clsOrderUser aUser = new clsOrderUser();
        //varaibles storing username and password
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        //varaible storing result of find operation
        Boolean Found = false;
        //get username entered by user
        UserName = Convert.ToString(txtUsername.Text);
        //get passsword entered by user
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = aUser.FindUser(UserName, Password);
        //add a session to capture the user name
        Session["aUser"] = aUser;
        //if username and/or password is empty
        if(txtUsername.Text == "")
        {
            lblError.Text = "Enter a username ";
        }
        else if(txtPassword.Text == "")
        {
            lblError.Text = "Enter a password ";
        }
        //if found
        else if(Found == true)
        {
            //redirect to orderlist page
            Response.Redirect("OrderList.aspx");
        }
        else if(Found == false)
        {
            //record error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}