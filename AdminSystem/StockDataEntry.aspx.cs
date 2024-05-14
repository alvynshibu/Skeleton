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
        clsStock aStock = new clsStock();
        aStock.StockId = Convert.ToInt32(txtStockId.Text);   
        aStock.ItemName = txtItemName.Text;
        aStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        aStock.Price = Convert.ToDecimal(txtPrice.Text); 
        aStock.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        aStock.Available = CheckBox1.Checked;
        aStock.OrderDate = Convert.ToDateTime(DateTime.Now);
        Session["aStock"] = aStock;
        Response.Redirect("StockViewer.aspx");
    }

 
}