<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerControlWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Select Fruit: </h1>
        <div>
            <asp:DropDownList ID="Fruits" runat="server"
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="118px"
                AutoPostBack="True">
                <asp:ListItem Value="1">Mango</asp:ListItem>
                <asp:ListItem Value="2">Apple</asp:ListItem>
                <asp:ListItem Value="3">Banana</asp:ListItem>
                <asp:ListItem Value="4">Kiwi</asp:ListItem>
            </asp:DropDownList>
        </div>
</asp:Content>
