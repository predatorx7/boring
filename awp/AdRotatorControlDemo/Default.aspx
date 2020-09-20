<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdRotatorControlDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:AdRotator ID="AdRotator1" OnAdCreated="AdRotator1_AdCreated" AdvertisementFile="~/Adfile.xml" runat="server" Target="_blank" Height="200px" Width="200px" />
    	<br />
		<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
