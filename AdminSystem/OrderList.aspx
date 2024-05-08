<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 166px;
        }
    </style>
</head>
<body>
    
   <form id="form1" runat="server">
        <div style="height: 165px">
            <asp:Label ID="lblOrderLineId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; bottom: 642px; width: 109px" Text="OrderLineId"></asp:Label>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 12px; top: 38px; position: absolute; height: 19px" Text="OrderId"></asp:Label>
            <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 16px; top: 68px; position: absolute" Text="StockId"></asp:Label>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 13px; top: 103px; position: absolute" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtOrderLineId" runat="server" style="z-index: 1; left: 130px; top: 17px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 130px; top: 41px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 128px; top: 66px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 128px; top: 95px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 14px; top: 151px; position: absolute" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 71px; top: 150px; position: absolute" Text="Cancel" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 127px; position: absolute"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
