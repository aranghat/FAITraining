<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieBasics.aspx.cs" Inherits="AspNetStateManagement.CookieBasics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="lblNote" runat="server" Text=""></asp:Label></h1>
            <asp:TextBox ID="txtNote" placeholder="Keep a note to remember" runat="server"></asp:TextBox>
            <asp:Button ID="btnSaveNote" runat="server" Text="Save Note" OnClick="btnSaveNote_Click" /></div>
    </form>
</body>
</html>
