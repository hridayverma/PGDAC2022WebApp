<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="PGDAC2022WebApp.DbOperations.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table align="center" style="width: 60%; border-collapse: collapse; border: 2px solid #FF0066; background-color: #99FFCC">
        <tr>
            <td colspan="2"><strong>Add User:</strong></td>
        </tr>
        <tr>
            <td>User Id:</td>
            <td>
                <asp:TextBox ID="TxtUserId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Full Name:</td>
            <td>
                <asp:TextBox ID="TxtFullName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <asp:TextBox ID="TxtEmail" TextMode="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Mobile:</td>
            <td>
                <asp:TextBox ID="TxtMobile" TextMode="Number" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address:</td>
            <td>
                <asp:TextBox ID="TxtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save Record" OnClick="btnSave_Click" />
            &nbsp;<asp:HyperLink ID="HyperLink1" 
                NavigateUrl="~/DbOperations/ViewUsers.aspx" runat="server">
                View All Users
                </asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" ></asp:Label>
            </td>
        </tr>
    </table>

</asp:Content>
