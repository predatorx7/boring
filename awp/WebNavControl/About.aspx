<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebNavControl.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>About Page</h1>
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
        <asp:Menu ID="Menu1" runat="server" Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"
                    Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Contact.aspx" Text="Contact"
                    Value="Contact"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
