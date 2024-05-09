<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 370px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Customer ID:" width="117px"></asp:Label>
        </div>
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 148px; top: 17px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Customer Name:" width="117px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 147px; top: 54px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 11px; top: 88px; position: absolute" Text="Customer Email:" width="117px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 15px; top: 128px; position: absolute" Text="Phone Number:" width="117px"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 146px; top: 89px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 15px; top: 166px; position: absolute" Text="Customer Address:"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 144px; top: 167px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblRegistrationDate" runat="server" style="z-index: 1; left: 16px; top: 207px; position: absolute" Text="Registration Date:" width="117px"></asp:Label>
        <asp:TextBox ID="txtRegistrationDate" runat="server" style="z-index: 1; left: 145px; top: 207px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 301px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 340px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 83px; top: 341px; position: absolute" Text="Cancel" />
        <asp:CheckBox ID="chkEmailNotifications" runat="server" style="z-index: 1; left: 147px; top: 260px; position: absolute; right: 169px;" Text="Email Notifications" />
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 145px; top: 130px; position: absolute" width="128px"></asp:TextBox>
    </form>
</body>
</html>
