<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DbConnection.aspx.cs" Inherits="PGDAC2022WebApp.DbOperations.DbConnection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1  class="text-danger text-center">Working with Database and ADO.NET </h1>
    <hr />
    <asp:Button ID="Button1" runat="server" Text="Connect with Database Server" OnClick="Button1_Click" /><br /><br />
    <asp:Button ID="Button2" runat="server" Text="Check Connection State" OnClick="Button2_Click" /><br /><br />
    <asp:Button ID="Button3" runat="server" Text="Disconnect from Database" OnClick="Button3_Click" />
</asp:Content>
