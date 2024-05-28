<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 605px; margin-top: 19px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerLogin" runat="server" style="z-index: 1; left: 27px; top: 51px; position: absolute; height: 22px; width: 190px" Text="Customer Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 51px; top: 116px; position: absolute; height: 20px; width: 74px" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 53px; top: 151px; position: absolute; height: 19px; width: 69px" Text="Password:"></asp:Label>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 129px; top: 116px; position: absolute; height: 15px; width: 148px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 130px; top: 152px; position: absolute; height: 16px; width: 148px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 54px; top: 193px; position: absolute; height: 23px; width: 232px"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 92px; top: 235px; position: absolute; height: 24px; width: 73px; right: 483px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 187px; top: 235px; position: absolute; height: 25px; width: 74px" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
