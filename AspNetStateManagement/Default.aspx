<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspNetStateManagement.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Products</h1>
            <asp:Label ID="lblProduct" runat="server" Text=""></asp:Label>
            <asp:DropDownList ID="ddlSelectProduct" 
                runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSelectProduct_SelectedIndexChanged"></asp:DropDownList>
           <%-- <asp:Button ID="Button1" runat="server"
                Text="Show Product Details"
                 PostBackUrl="~/Details.aspx"
                />--%>
            <br />
            <asp:Label ID="lblPageView" ForeColor="Red" runat="server" Text="Label"></asp:Label>
              <asp:Label ID="Label1" ForeColor="Blue" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
