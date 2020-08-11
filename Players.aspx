<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="ClassAssignment.Players" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Which is your Favourite Game?<br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricket" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="LawnTennis" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="The list of players in cricket :"></asp:Label>
&nbsp;<br />
            <asp:Panel ID="Panel3" runat="server" Width="208px">
                <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/SachinTendulkar.html">Sachin Tendulkar</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Sunil Gavaskar.html">Sunil Gavaskar</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/MSDhoni.html">MS Dhoni</asp:HyperLink>
            </asp:Panel>
            <br />
            <asp:Label ID="Label2" runat="server" Text="The list of players in lawn tennis :"></asp:Label>
            <br />
            <asp:Panel ID="Panel2" runat="server" Width="210px">
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/DominicThiem.html">Dominic Thiem</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/RafaelNadal.html">Rafael Nadal</asp:HyperLink>
                <br />
                <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/RogerFederer.html">Roger Federer.</asp:HyperLink>
            </asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
