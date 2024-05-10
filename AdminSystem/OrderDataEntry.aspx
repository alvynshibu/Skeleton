<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 272px;
            width: 354px;
        }
    </style>
</head>
<body style="height: 304px; width: 389px">
    &nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtOrderId" runat="server" OnTextChanged="txtOrderId_TextChanged" style="z-index: 1; left: 117px; top: 24px; position: absolute; width: 186px"></asp:TextBox>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 15px; top: 26px; position: absolute; width: 101px" Text="OrderId"></asp:Label>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 8px; top: 69px; position: absolute; right: 261px" Text="CustomerId" width="101px"></asp:Label>
        <p style="height: 55px">
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 117px; top: 65px; position: absolute; height: 19px; width: 186px"></asp:TextBox>
            <asp:Label ID="lblDeliveryAddress" runat="server" style="z-index: 1; left: 11px; top: 111px; position: absolute" Text="DeliveryAddress"></asp:Label>
            <asp:TextBox ID="txtDeliveryAddress" runat="server" style="z-index: 1; left: 117px; top: 112px; position: absolute; width: 186px; margin-top: 0px"></asp:TextBox>
            <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 13px; top: 151px; position: absolute; bottom: 702px" Text="Order Date" width="101px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" Style="z-index: 1; left: 117px; top: 151px; position: absolute; width: 186px"></asp:TextBox>
            <asp:Label ID="lblDeliveryStatus" runat="server" style="z-index: 1; left: 13px; top: 188px; position: absolute" Text="Delivery Status" width="101px"></asp:Label>
            <asp:Label ID="lblOrderAmount" runat="server" style="z-index: 1; left: 14px; top: 223px; position: absolute" Text="Total Amount" width="101px"></asp:Label>
            <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 117px; top: 225px; position: absolute; width: 186px"></asp:TextBox>
            <asp:CheckBox ID="chkDeliveryStatus" runat="server" style="z-index: 1; left: 121px; top: 187px; position: absolute" Text="Delivered" width="186px" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 261px; position: absolute; bottom: 588px"></asp:Label>
        &nbsp;<asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 20px; top: 294px; position: absolute" Text="OK" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 99px; top: 293px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 342px; top: 23px; position: absolute; height: 26px" Text="Find" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
