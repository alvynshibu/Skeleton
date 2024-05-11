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
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 176px; top: 16px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 132px;" Text="Customer Name:"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 176px; top: 51px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 11px; top: 88px; position: absolute; width: 134px;" Text="Customer Email:"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 15px; top: 128px; position: absolute; width: 127px;" Text="Phone Number:"></asp:Label>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 174px; top: 87px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 15px; top: 166px; position: absolute" Text="Customer Address:"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 173px; top: 167px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblRegistrationDate" runat="server" style="z-index: 1; left: 16px; top: 207px; position: absolute; width: 145px;" Text="Registration Date:"></asp:Label>
        <asp:TextBox ID="txtRegistrationDate" runat="server" style="z-index: 1; left: 175px; top: 207px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 301px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 340px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 83px; top: 341px; position: absolute" Text="Cancel" />
        <asp:CheckBox ID="chkEmailNotifications" runat="server" style="z-index: 1; left: 147px; top: 260px; position: absolute; right: 169px;" Text="Email Notifications" />
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 174px; top: 129px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 354px; top: 27px; position: absolute; width: 79px; height: 27px" Text="Find" />
    </form>
</body>
</html>
