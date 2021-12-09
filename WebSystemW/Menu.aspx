<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMenu.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebSystemW.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="FomMenu">
        <h1>hola mundo C#</h1>
        <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
