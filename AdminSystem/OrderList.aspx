<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 176px;
        }
    </style>
</head>
<body>
    
   
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" Height="173px" Width="203px"></asp:ListBox><asp:Button runat="server" Text="Button" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
    </form>
    
   
</body>
</html>
