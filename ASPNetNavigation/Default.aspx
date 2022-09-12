<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNetNavigation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <%--  <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <Items>
                <asp:MenuItem NavigateUrl="#" Text="Search" Value="Search">
                    <asp:MenuItem NavigateUrl="http://google.com" Text="Google" Value="Google">
                        <asp:MenuItem NavigateUrl="http://images.google.com" Text="Google Images" Value="Google Images"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="http://bing.com" Text="Bing" Value="Bing"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="https://yahoo.com" Text="Yahoo" Value="Yahoo"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>--%>
        <div>
              <h1>Dashboard
              </h1>
        </div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="XPFileExplorer" NodeIndent="15">
            <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
            <Nodes>
                
                <asp:TreeNode Text="Root" Value="Root"></asp:TreeNode>
                
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" BackColor="#B5B5B5" />
        </asp:TreeView>
        <asp:DropDownList ID="DropDownList1" 
            runat="server" 
            AutoPostBack="true" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="http://google.com">Google</asp:ListItem>
             <asp:ListItem Value="http://msdn.com">MSDN</asp:ListItem>
             <asp:ListItem Value="http://microsoft.com">Microsoft</asp:ListItem>
        </asp:DropDownList>
        <asp:HyperLink ID="HyperLink1"
            NavigateUrl="~/ProductDetails.aspx"
            runat="server">Go to product details</asp:HyperLink>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"
            PostBackUrl="~/ProductDetails.aspx"
            >Navigate</asp:LinkButton>
    </form>
</body>
</html>
