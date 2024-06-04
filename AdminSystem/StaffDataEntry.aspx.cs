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
}
