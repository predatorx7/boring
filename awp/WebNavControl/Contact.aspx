<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebNavControl.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Contact Page</h1>
    <div>
        <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
        <asp:Menu ID="Menu1" runat="server" Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"
                    Value="Home"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/About.aspx" Text="About"
                    Value="About"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
