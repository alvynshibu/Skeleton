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

    protected void txtOrderId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instanc of clsOrder
        clsOrder anOrder = new clsOrder();
        //capture order id
        anOrder.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        anOrder.DeliveryAddress = txtDeliveryAddress.Text;
        anOrder.DateAdded = Convert.ToDateTime(txtOrderDate.Text);
        anOrder.DeliveryStatus = chkDeliveryStatus.Checked;
        anOrder.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        //store address in session object
        Session["anOrder"] = anOrder;

        //navigate to view page
        Response.Redirect("OrderViewer.aspx");
    }
}