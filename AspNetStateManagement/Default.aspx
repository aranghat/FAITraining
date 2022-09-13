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
            <asp:DropDownList ID="ddlSelectProduct" 
                runat="server"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server"
                Text="Show Product Details"
                 PostBackUrl="~/Details.aspx"
                />
        </div>
    </form>
</body>
</html>
