<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 20px; position: absolute; height: 19px; bottom: 626px" Text="Staff ID"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 106px; top: 19px; position: absolute; height: 22px; width: 128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblName" runat="server" height="19px" style="z-index: 1; left: 12px; top: 54px; position: absolute" Text="Name" width="48px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 107px; top: 54px; position: absolute; height: 22px; width: 128px" OnTextChanged="txtName_TextChanged"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 91px; position: absolute; width: 89px; height: 19px" Text="Date of Birth"></asp:Label>
        <p>
            &nbsp;
            <asp:Button runat="server" Text="Find" Style="z-index: 1; left: 400px; top: 30px; position: absolute" ID="btnFind" OnClick="btnFind_Click"></asp:Button></p>
        <p>
            <asp:TextBox ID="txtDateOfBirth" runat="server" height="22px" style="z-index: 1; left: 106px; top: 90px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server" height="19px" style="z-index: 1; left: 13px; top: 127px; position: absolute" Text="Email" width="48px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" height="22px" style="z-index: 1; top: 125px; position: absolute; left: 104px" width="128px"></asp:TextBox>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; position: absolute; width: 48px; height: 19px; top: 163px" Text="Address"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtAddress" runat="server" Style="z-index: 1; left: 107px; top: 161px; position: absolute; bottom: 482px" Height="22px" Width="128px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkNotification" runat="server" style="z-index: 1; left: 93px; top: 203px; position: absolute" Text="Notification" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 234px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 281px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 86px; top: 280px; position: absolute" Text="Cancel" />
        </p>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 218px; top: 286px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
