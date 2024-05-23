<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 448px; position: absolute"></asp:Label>
        <br />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 99px; top: 404px; position: absolute" Text="Edit" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
