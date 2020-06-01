<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="En-FrHomePage.aspx.cs" Inherits="AspExercise.En_FrHomePage" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            No.Client
            <asp:DropDownList ID="drpClient" runat="server" meta:resourcekey="drpClientResource1">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="orderlistbtn" runat="server" OnClick="orderlistbtn_Click" Text="Order List" Width="150px" meta:resourcekey="orderlistbtnResource1" />
            <br />
            <br />
            <asp:Button ID="DisplayOrderbtn" runat="server" Text="Display Order" Width="150px" meta:resourcekey="DisplayOrderbtnResource1" OnClick="DisplayOrderbtn_Click" />
        </div>
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/En-FrHomePage.aspx?lang=En">En</asp:HyperLink>
&nbsp;-
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/En-FrHomePage.aspx?lang=Fr">Fr</asp:HyperLink>
        </div>
    </form>
</body>
</html>
