<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 295px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtQuestion" runat="server" Width="372px">Are you sure you want to delete this record</asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnYes" runat="server" Height="27px" OnClick="btnYes_Click" Text="Yes" Width="45px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNo" runat="server" Height="27px" OnClick="btnNo_Click" Text="No" Width="45px" />
        </p>
    </form>
</body>
</html>
