<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 636px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" Height="351px" Width="382px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 28px; top: 403px; position: absolute" Text="Add" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 173px; top: 405px; position: absolute; height: 23px; width: 57px" Text="Delete" />
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 28px; top: 467px; position: absolute; width: 104px" Text="Enter an Email:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 141px; top: 464px; position: absolute; height: 22px; width: 156px"></asp:TextBox>
        <br />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 99px; top: 404px; position: absolute" Text="Edit" />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 570px; position: absolute; height: 22px;"></asp:Label>
        <asp:Button ID="btnReturnToMainMenu" runat="server" style="z-index: 1; left: 309px; top: 516px; position: absolute; width: 139px; height: 28px; bottom: 121px" Text="Return To Main Menu" />
        <br />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 32px; top: 518px; position: absolute; height: 26px; width: 109px; right: 736px" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 163px; top: 518px; position: absolute; width: 121px" Text="Clear Filter" />
        <br />
        <br />
    </form>
</body>
</html>
