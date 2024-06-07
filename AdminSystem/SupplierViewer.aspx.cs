using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier aSupplier = new clsSupplier();
        //get the data from the session object
        aSupplier = (clsSupplier)Session["aSupplier"];
        //display the supplier name for this entry
        Response.Write(aSupplier.SupplierName);
        Response.Write(aSupplier.SupplierEmail);
        Response.Write(aSupplier.SupplierAddress);
        Response.Write(aSupplier.SupplierId);
        Response.Write(aSupplier.SupplierPhoneNumber);
        Response.Write(aSupplier.SupplierContactPerson);

    }
}