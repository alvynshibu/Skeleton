<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 265px;
        }
    </style>
</head>
<body>
    
   
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="173px" Width="203px"></asp:ListBox>
        <asp:Button style="position:absolute; top: 194px; left: 16px;" runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 194px; position: absolute; right: 275px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 234px; position: absolute"></asp:Label>
    </form>
    
   
</body>
</html>
