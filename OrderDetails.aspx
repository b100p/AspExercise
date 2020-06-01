<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="AspExercise.OrderDetails" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1" Text="Details of the order"></asp:Label>
&nbsp;<asp:Label ID="Orderlbl" runat="server" meta:resourcekey="OrderlblResource1" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="OrderDetials" runat="server" meta:resourcekey="OrderDetialsResource1">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
