<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 314px;
            width: 354px;
        }
    </style>
</head>
<body style="height: 357px; width: 389px">
    &nbsp;<form id="form1" runat="server">
        <asp:TextBox ID="txtOrderId" runat="server" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 132px; top: 21px; position: absolute; width: 188px; bottom: 630px;" Height="20px"></asp:TextBox>
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 13px; top: 26px; position: absolute; width: 101px" Text="OrderId"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 13px; top: 69px; position: absolute; " Text="CustomerId" width="101px"></asp:Label>
        <p style="height: 55px">
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 132px; top: 65px; position: absolute; height: 21px; width: 186px" Height="20px"></asp:TextBox>
            <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 13px; top: 111px; position: absolute" Text="Delivery Address"></asp:Label>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 13px; top: 151px; position: absolute; bottom: 505px" Text="Order Date" width="101px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" Style="z-index: 1; left: 132px; top: 151px; position: absolute; width: 186px" Height="20px"></asp:TextBox>
            <asp:Label ID="lblDeliveryStatus" runat="server" style="z-index: 1; left: 13px; top: 188px; position: absolute" Text="Delivery Status" width="101px"></asp:Label>
            <asp:Label ID="lblOrderAmount" runat="server" style="z-index: 1; left: 13px; top: 223px; position: absolute" Text="Total Amount" width="101px"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 132px; top: 220px; position: absolute; width: 186px" Height="20px"></asp:TextBox>
            <asp:CheckBox ID="chkDeliveryStatus" runat="server" style="z-index: 1; left: 136px; top: 187px; position: absolute" Text="Delivered" width="186px" />
            <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; left: 132px; top: 107px; position: absolute; width: 186px; margin-top: 0px" Height="20px"></asp:TextBox>
        </p>
        &nbsp;<p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 99px; top: 330px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 342px; top: 23px; position: absolute; height: 26px" Text="Find" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 291px; position: absolute; bottom: 357px"></asp:Label>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 13px; top: 261px; position: absolute; bottom: 396px" Text="StaffId"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" Height="20px" style="z-index: 1; left: 132px; top: 258px; position: absolute; width: 186px"></asp:TextBox>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click1" style="z-index: 1; left: 19px; top: 331px; position: absolute" Text="OK" />
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 207px; top: 329px; position: absolute" Text="Return to Main Menu" />
        </p>
    </form>
</body>
</html>
