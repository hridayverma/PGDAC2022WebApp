<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PGDAC2022WebApp.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Put your source code here as per your interface requirements -->
    <table style="width:40%;margin:auto;border:5px solid green">
        <tr><td colspan="2" align="center">Login Here</td></tr>
        <tr><td>User Name:</td>
            <td>
            <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr><td>Password:</td><td>
            <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
            </td></tr>
        <tr><td>
            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me" />
            </td><td>
                <asp:Button ID="BtnLogin" runat="server" Text="Sign In" 
                    OnClick="BtnLogin_Click"  />                
            </td></tr>
        <tr><td colspan="2">
            <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>
            </td></tr>
             
    </table>

</asp:Content>
