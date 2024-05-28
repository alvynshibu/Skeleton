<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 404px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 205px; top: 38px; position: absolute" Text="Main Menu"></asp:Label>
        <asp:Button ID="btnOrders" runat="server" OnClick="btnOrders_Click" style="z-index: 1; left: 89px; top: 96px; position: absolute" Text="Orders" />
        <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 24px; top: 96px; position: absolute; right: 449px" Text="Stock" Width="50px" OnClick="btnStock_Click" />
        <asp:Button ID="btnCustomers" runat="server" style="z-index: 1; left: 165px; top: 96px; position: absolute" Text="Customers" OnClick="btnCustomers_Click" />
        <asp:Button ID="btnStaff" runat="server" style="z-index: 1; left: 276px; top: 96px; position: absolute" Text="Staff Members" />
        <asp:Button ID="btnSuppliers" runat="server" style="z-index: 1; left: 425px; top: 96px; position: absolute" Text="Suppliers" />
    </form>
</body>
</html>
