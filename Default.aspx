<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebWCF._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />

    <asp:Label ID="Label1" runat="server" Text="Angka 1"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Label ID="Label2" runat="server" Text="Angka 2"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br /><br />

    <asp:Button ID="Button1" runat="server" Text="Tambah" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Kurang" OnClick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="Kali" OnClick="Button3_Click" />
    <asp:Button ID="Button4" runat="server" Text="Bagi" OnClick="Button4_Click" />
    <br /><br />

    <asp:Label ID="Label3" runat="server" Text="Hasil"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

</asp:Content>
