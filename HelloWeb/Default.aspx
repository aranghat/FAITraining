<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></h1>
        </div>
        <asp:TextBox ID="txtCTC" runat="server"></asp:TextBox>
        <asp:DropDownList ID="ddlGender" runat="server">
            <asp:ListItem Value="Male">Male</asp:ListItem>
             <asp:ListItem Value="Female">Female</asp:ListItem>
             <asp:ListItem Value="Others">Others</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBox ID="chkIsExempted" 
            Text="Is Exempted From Tax" runat="server" />
        <asp:Button ID="Button1" 
            runat="server" 
            Text="Calculate Tax" 
            OnClick="Button1_Click" />

        <asp:Image ID="Image1" Width="100" Height="100"  
            ImageUrl="~/Images/tiger.jpg" 
            runat="server" />
    </form>
</body>
</html>
