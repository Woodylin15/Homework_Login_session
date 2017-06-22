<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2">
                User name:</td>
            <td>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="lblPrompt" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" Text="Login" 
                    Width="98px" />
                <asp:Label ID="lblPrompt0" runat="server">你還沒有會員帳號!？你這是浪費人生。</asp:Label>
                <a href ="CreateAccount.aspx" runat="server">立即註冊</a>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
<p>
    <br />
</p>
</asp:Content>

