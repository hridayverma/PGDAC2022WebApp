<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageUsers.aspx.cs" Inherits="PGDAC2022WebApp.DbOperations.ManageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table align="center" style="width: 60%; border-collapse: collapse; border: 2px solid #FF0066; background-color: #99FFCC">
        <tr>
            <td colspan="2"><strong>Manage User:</strong></td>
        </tr>
        <tr>
            <td>User Id:</td>
            <td>
                <asp:TextBox ID="TxtUserId" runat="server"></asp:TextBox>
                <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Find User" />
            </td>
        </tr>
        <tr>
            <td>Full Name:</td>
            <td>
                <asp:TextBox ID="TxtFullName" runat="server"></asp:TextBox>
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
            <td>
                <asp:Button ID="BtnShow" runat="server" Text="View All" />
            </td>
            <td>
                <asp:Button ID="BtnUpdate" runat="server" Text="Update Record"  />
               &nbsp; <asp:Button ID="BtnDelete" runat="server" Text="Delete Record"  />
            &nbsp;<asp:HyperLink ID="HyperLink1" 
                NavigateUrl="~/DbOperations/AddUser.aspx" runat="server">
                Add New User
                </asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" style="font-weight: 700" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
