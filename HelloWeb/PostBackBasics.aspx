<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackBasics.aspx.cs" Inherits="HelloWeb.PostBackBasics" %>

<!DOCTYPE html>

<html xml
<input id="Password1" type="password" />ns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <asp:HiddenField ID="hdnSomeContent" runat="server" />
            <asp:TextBox ID="TextBox1" runat="server" 
                ViewStateMode="Disabled"
                EnableViewState="false"
                 AutoPostBack="true"
                OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:DropDownList ID="ddlFavHeros"
                 AutoPostBack="true"
                runat="server"
                OnSelectedIndexChanged="ddlFavHeros_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="btnSeletHero" runat="server" Text="Select Hero" OnClick="btnSeletHero_Click" />
        </div>
    </form>
</body>
</html>
