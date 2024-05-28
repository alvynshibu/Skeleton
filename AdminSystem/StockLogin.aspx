<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockLogin.aspx.cs" Inherits="StockLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 383px; top: 160px; position: absolute; width: 152px; height: 25px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 222px; top: 162px; position: absolute; width: 91px; height: 24px" Text="UserName"></asp:Label>
        </p>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 217px; top: 205px; position: absolute; width: 68px; height: 23px" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 383px; top: 205px; position: absolute; width: 152px; height: 28px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 594px; top: 182px; position: absolute; height: 29px; width: 106px"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 305px; top: 326px; position: absolute; height: 23px; width: 116px" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 473px; top: 327px; position: absolute; height: 23px; width: 125px" Text="Cancel" />
    </form>
</body>
</html>
