<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="UserCtrlDemo.WebUserControl1" %>
<h3>User Information</h3>
<table>
    <tr>
        <td>Name</td>
        <td>
            <asp:TextBox ID="txtName" runat="server"
                OnTextChanged="txtName_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Age</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"
                OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>City</td>
        <td>
            <asp:TextBox ID="txtcity" runat="server"
                OnTextChanged="txtcity_TextChanged"></asp:TextBox></td>
    </tr>
</table>
<br />
<asp:Label ID="Label1" runat="server" Text=" "></asp:Label><br />
<asp:Label ID="Label2" runat="server" Text=" "></asp:Label><br />
<asp:Label ID="Label3" runat="server" Text=" "></asp:Label><br />
<asp:Button ID="txtSave" runat="server" Text="Save" OnClick="txtSave_Click" />