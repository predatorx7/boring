<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TreeViewAndDataList._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TreeView ID="TreeView1" runat="server" Width="171px" ImageSet="Arrows"
        Height="127px">
        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
        <Nodes>
            <asp:TreeNode Text="Other Pages" Value="New Node">
                <asp:TreeNode Text="Contact" Value="RED" NavigateUrl="Contact.aspx"></asp:TreeNode>
                <asp:TreeNode Text="About" Value="GREEN"
                    NavigateUrl="About.aspx"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black"
            HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD"
            HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
    <br />
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="table" border="1">
                <tr>
                    <td>Roll Num : <%# Eval("sid") %><br />
                        Name : <%# Eval("sname") %><br />
                        Class : <%# Eval("sclass")%>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
