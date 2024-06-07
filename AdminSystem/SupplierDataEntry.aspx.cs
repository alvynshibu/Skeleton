using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 supplierId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        supplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (supplierId != -1)
            {
                //display the current data for the record
                DisplaySupplier();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier aSupplier = new clsSupplier();
        //capture the supplier name
        string supplierName = txtSupplierName.Text;
        //capture the supplier address
        string supplierAddress = txtSupplierAddress.Text;
        //capture the contact person
        string contactPerson = txtSupplierContact.Text;
        //capture the email
        string email = txtSupplierEmail.Text;
        //capture the phone number
        string phone = txtSupplierPhone.Text;
        //variable to store any error messages
        string error = "";
        //validate the data
        error = aSupplier.Valid(supplierName, supplierAddress, contactPerson, email, phone);
        if (error == "")
        {
            //capture the supplier id
            aSupplier.SupplierId = supplierId;
            //capture the supplier name
            aSupplier.SupplierName = supplierName;
            //capture the supplier address
            aSupplier.SupplierAddress = supplierAddress;
            //capture the contact person
            aSupplier.SupplierContactPerson = contactPerson;
            //capture the email
            aSupplier.SupplierEmail = email;
            //capture the phone number
            aSupplier.SupplierPhoneNumber = phone;

            //create a new instance of the supplier collection
            clsSupplierCollection supplierList = new clsSupplierCollection();

            //if this is a new record i.e. supplierId = -1 then add the data
            if (supplierId == -1)
            {
                //set the ThisSupplier property
                supplierList.ThisSupplier = aSupplier;
                //add the new record
                supplierList.Add();
            }
            else
            {
                //find the record to update
                supplierList.ThisSupplier.Find(supplierId);
                //set the ThisSupplier property
                supplierList.ThisSupplier = aSupplier;
                //update the record
                supplierList.Update();
            }
            //redirect back to the list page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier class
        clsSupplier aSupplier = new clsSupplier();
        //create a variable to store the primary key
        Int32 supplierId;
        //create a variable to store the result of the find operation
        Boolean found = false;
        //get the primary key entered by the user
        supplierId = Convert.ToInt32(txtSupplierId.Text);
        //find the record
        found = aSupplier.Find(supplierId);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = aSupplier.SupplierName;
            txtSupplierAddress.Text = aSupplier.SupplierAddress;
            txtSupplierContact.Text = aSupplier.SupplierContactPerson;
            txtSupplierEmail.Text = aSupplier.SupplierEmail;
            txtSupplierPhone.Text = aSupplier.SupplierPhoneNumber;
        }
    }

    void DisplaySupplier()
    {
        //create an instance of the supplier book
        clsSupplierCollection supplierBook = new clsSupplierCollection();
        //find the record to update
        supplierBook.ThisSupplier.Find(supplierId);
        //display the data for the record
        txtSupplierId.Text = supplierBook.ThisSupplier.SupplierId.ToString();
        txtSupplierName.Text = supplierBook.ThisSupplier.SupplierName;
        txtSupplierAddress.Text = supplierBook.ThisSupplier.SupplierAddress;
        txtSupplierContact.Text = supplierBook.ThisSupplier.ContactPerson;
        txtSupplierEmail.Text = supplierBook.ThisSupplier.Email;
        txtSupplierPhone.Text = supplierBook.ThisSupplier.Phone;
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        //redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
