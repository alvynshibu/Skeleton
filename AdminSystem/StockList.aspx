<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStockList" runat="server" Height="190px" Width="268px"></asp:ListBox>
        <div>
        
        </div>

        

       





        <p>
        
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="60px" />
        <asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </p>
        <p>
            Enter a ItemName<asp:TextBox ID="txtFilter" runat="server" Height="19px" style="margin-left: 52px; margin-top: 0px" Width="223px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="margin-left: 157px" Text="Apply Filter" Width="101px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="margin-left: 50px" Text="Clear Filter" Width="142px" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 486px; top: 374px; position: absolute; width: 157px" Text="Return to Main Menu" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>

        

       





    </form>
    
</body>
    </html>
