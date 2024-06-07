<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 370px">
    <asp:Label runat="server" Text="Label"></asp:Label>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSupplierId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Supplier ID:" width="117px"></asp:Label>
        </div>
        <asp:TextBox ID="txtSupplierId" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 220px; top: 16px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; width: 132px;" Text="Supplier Name:"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 220px; top: 51px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 10px; top: 88px; position: absolute; width: 132px;" Text="Supplier Email:"></asp:Label>
        <asp:Label ID="lblSupplierPhone" runat="server" style="z-index: 1; left: 10px; top: 128px; position: absolute; width: 132px;" Text="Supplier Phone:"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 220px; top: 87px; position: absolute" Width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSupplierPhone" runat="server" style="z-index: 1; left: 220px; top: 129px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierContact" runat="server" style="z-index: 1; left: 10px; top: 166px; position: absolute; width: 132px;" Text="Contact Person:"></asp:Label>
        <asp:TextBox ID="txtSupplierContact" runat="server" style="z-index: 1; left: 220px; top: 167px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 10px; top: 206px; position: absolute; width: 132px;" Text="Supplier Address:"></asp:Label>
        <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 220px; top: 207px; position: absolute" Width="128px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 301px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 21px; top: 340px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 83px; top: 341px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtPhoneNumber" runat="server" Style="z-index: 1; left: 220px; top: 128px; position: absolute" Width="128px" OnTextChanged="txtPhoneNumber_TextChanged"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 354px; top: 27px; position: absolute; width: 79px; height: 27px" Text="Find" />
        <asp:Button ID="btnReturnToMainMenu" runat="server" OnClick="btnReturnToMainMenu_Click" style="z-index: 1; left: 177px; top: 342px; position: absolute; height: 24px; width: 150px" Text="Return To Main Menu" />
    </form>
</body>
</html>
