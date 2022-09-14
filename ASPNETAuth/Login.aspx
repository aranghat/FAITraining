<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPNETAuth.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>
            <asp:Label ID="lblUseRName" runat="server" Text="Enter your user name"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
             <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="SignIn" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
