<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 372px;
        }
    </style>
</head>
<body>
    
   
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="173px" Width="203px"></asp:ListBox>
        <asp:Button style="position:absolute; top: 194px; left: 16px;" runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 194px; position: absolute; right: 275px" Text="Edit" Width="50px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 336px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 139px; top: 194px; position: absolute" Text="Delete" />
        <asp:Label ID="lblEnterAddress" runat="server" style="z-index: 1; left: 20px; top: 240px; position: absolute" Text="Enter an Address"></asp:Label>
        <asp:TextBox ID="txtEnterAddress" runat="server" style="z-index: 1; left: 148px; top: 239px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 27px; top: 285px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 160px; top: 285px; position: absolute" Text="Clear Filter" />
    </form>
    
   
</body>
</html>
