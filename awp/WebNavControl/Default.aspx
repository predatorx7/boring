<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebNavControl._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Home Page</h1>
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
        <asp:Menu ID="Menu1" runat="server" Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="~/About.aspx" Text="About"
                    Value="About"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Contact.aspx" Text="Contact"
                    Value="Contact"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
