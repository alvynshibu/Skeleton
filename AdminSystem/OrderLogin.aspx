<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 333px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 9px; top: 43px; position: absolute" Text="Order Login Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 62px; top: 147px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 65px; top: 198px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 170px; top: 146px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 170px; top: 197px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 173px; top: 243px; position: absolute; right: 328px" Text="Login" Width="50px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 238px; top: 243px; position: absolute" Text="Cancel" />
        <p>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 382px; top: 170px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
