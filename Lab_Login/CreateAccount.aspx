<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateAccount.aspx.cs" Inherits="CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <h3>輸入您的帳號：</h3>
            <asp:TextBox ID  ="userAccount" runat ="server"></asp:TextBox>
        </div>
        <div>
            <h3>輸入您的密碼：</h3>
            <asp:TextBox ID  ="userPassword" runat ="server"></asp:TextBox>
        </div>
        <div>
            <h3>輸入您的真實姓名：</h3>
            <asp:TextBox ID  ="actualName" runat ="server"></asp:TextBox>
        </div>
        <div>
            <h3>輸入您的年齡：</h3>
            <asp:TextBox ID  ="age" runat ="server"></asp:TextBox>
        </div>
    </div>
        <br />
    <asp:Button ID ="button" runat ="server" Text="確認新增" OnClick="button_Click" />
    </form>
</body>
</html>
