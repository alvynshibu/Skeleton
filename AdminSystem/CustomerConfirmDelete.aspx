
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 324px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 27px; top: 29px; position: absolute; width: 295px" Text="Are you sure you want to delete this record?"></asp:Label>
        <p style="height: 20px">
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 42px; top: 76px; position: absolute; width: 77px; height: 22px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 147px; top: 75px; position: absolute; width: 80px; height: 24px; bottom: 566px" Text="No" />
        </p>
    </form>
</body>
</html>
