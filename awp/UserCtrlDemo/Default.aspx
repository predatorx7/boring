<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserCtrlDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%@ Register Src="~/WebUserControl1.ascx" TagName="WebControl" TagPrefix="TWebControl" %>
    <TWebControl:WebControl ID="Header" runat="server" />
</asp:Content>
