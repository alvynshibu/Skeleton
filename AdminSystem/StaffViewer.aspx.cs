using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //get data from session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the Name
        Response.Write(AnStaff.Name); 

        Response.Write(AnStaff.DateOfBirth);

        Response.Write(AnStaff.Email);

        Response.Write(AnStaff.Notification);

        Response.Write(AnStaff.Address);









    }
}