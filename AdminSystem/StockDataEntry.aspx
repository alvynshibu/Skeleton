﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 502px">
    <form id="form1" runat="server">
        <div style="margin-left: 800px">
            <asp:TextBox ID="txtStockId" runat="server" style="z-index: 1; left: 177px; top: 49px; position: absolute"></asp:TextBox>
        </div>
        <p>
        <asp:Label ID="lblStockId" runat="server" style="z-index: 1; left: 26px; top: 48px; position: absolute; width: 81px;" Text="Stock ID"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 406px" Text="Find" Width="135px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; top: 187px; position: absolute; height: 19px; width: 78px; left: 11px;" Text="Quantity"></asp:Label>
            <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="ItemName"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 11px; top: 248px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 177px; top: 192px; position: absolute"></asp:TextBox>
        <p style="margin-left: 760px">
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 15px; top: 302px; position: absolute" Text="SupplierId"></asp:Label>
            <asp:TextBox ID="txtItemName" runat="server" Style="z-index: 1; left: 177px; top: 128px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblAvailable" runat="server" style="z-index: 1; left: 17px; top: 360px; position: absolute" Text="Available"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 19px; top: 410px; position: absolute" Text="OrderDate"></asp:Label>
        <p>
        </p>
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 26px; top: 478px; position: absolute" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 25px; top: 519px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 117px; top: 520px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:TextBox ID="txtSupplierId" runat="server" style="z-index: 1; left: 177px; top: 310px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 177px; top: 249px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="chkAvailable" runat="server" style="z-index: 1; left: 177px; top: 359px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrder" runat="server" style="z-index: 1; left: 177px; top: 413px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 179px; top: 479px; position: absolute" Text="Active" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 253px; top: 521px; position: absolute; height: 23px" Text="Return to Main Menu" />
        </p>
    </form>
</body>
            
</html>
