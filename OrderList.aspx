<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="AspExercise.OrderList" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Client :
            <asp:Label ID="clientnbr" runat="server" meta:resourcekey="clientnbrResource1" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" Text="Orders"></asp:Label>
            :
            <asp:DropDownList ID="drpOrders" runat="server" meta:resourcekey="drpOrdersResource1" ViewStateMode="Enabled">
            </asp:DropDownList>
            <br />
            <asp:Button ID="details" runat="server" meta:resourcekey="detailsResource1" OnClick="details_Click" Text="Details" ViewStateMode="Enabled" Width="123px" />
        </div>
    </form>
</body>
</html>
