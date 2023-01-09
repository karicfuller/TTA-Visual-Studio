<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Intro_to_Web_Forms.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <abbr title="Phone">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </abbr>
        <br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><abbr title="Phone"><asp:Button ID="Button1" runat="server" Text="Button" Width="199px" />
        </abbr>
        <br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
