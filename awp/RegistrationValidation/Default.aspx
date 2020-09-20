<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RegistrationValidation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style:"font-family:Verdana">
        Your Name :
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="reqName" ForeColor="Red"
            ControlToValidate="txtName" ErrorMessage="Please Enter Your Name!" />
        <br />
        Enter Your Age :
        <asp:TextBox ID="txt1" runat="server"
            Width="56px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" Type="Integer" runat="server"
            ForeColor="Red" ControlToValidate="txt1" MinimumValue="18" MaximumValue="100"
            ErrorMessage="Please Enter a Valid Age"></asp:RangeValidator>
        <br />
        Password :
        <asp:TextBox ID="txt11" runat="server"></asp:TextBox>
        <br />
        Re-enter password :
        <asp:TextBox ID="txt12" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cmpNumbers" runat="server" ControlToCompare="txt11"
            ControlToValidate="txt12" ErrorMessage="Password Do Not Match!"
            ForeColor="Red"
            Operator="Equal" Type="Integer">Password should match!</asp:CompareValidator>
        <br />
        <br />
        Email :<asp:TextBox ID="txtNumber" runat="server" Width="207px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="rexNumber" runat="server"
            ControlToValidate="txtNumber" ErrorMessage="Please enter a valid email address"
            ForeColor="Red"
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Please enter
    valid email address!</asp:RegularExpressionValidator>
        <br />
        Custom text:<asp:TextBox ID="txtCustom" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server"
            ClientValidationFunction="ServerValidation" ControlToValidate="txtCustom"
            ErrorMessage="CustomValidator" ForeColor="Red"></asp:CustomValidator>

        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click"
            Text="Validate Form" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="61px" />
    </div>
</asp:Content>
