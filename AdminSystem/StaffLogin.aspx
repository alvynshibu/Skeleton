<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 133px; top: 138px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 129px; top: 187px; position: absolute" Text="Password"></asp:Label>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 230px; top: 137px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 231px; top: 184px; position: absolute; height: 20px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 171px; top: 275px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 293px; top: 277px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 417px; top: 165px; position: absolute"></asp:Label>
    </form>
</body>
</html>
