<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 8px; top: 12px; position: absolute; height: 244px; width: 276px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 14px; top: 295px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 96px; top: 292px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 429px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 187px; top: 294px; position: absolute" Text="Delete" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 22px; top: 337px; position: absolute" Text="Enter Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 117px; top: 332px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 30px; top: 373px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 182px; top: 371px; position: absolute" Text="Clear Filter" />
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 309px; top: 329px; position: absolute" Text="Return To MainMenu" />
    </form>
</body>
</html>
