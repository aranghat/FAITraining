<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupControls.aspx.cs" Inherits="HelloWeb.GroupControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel2" CssClass="card" runat="server" 
                GroupingText="Select Fav Foods">
                </asp:Panel>
            <asp:Panel ID="Panel1" runat="server"
                GroupingText="Select Fav Fruits">
                 <asp:ListBox Width="300" Height="500" 
                     ID="lbFavFruits" 
                     SelectionMode="Multiple" runat="server">
                
            </asp:ListBox>
           <%-- <asp:CheckBoxList ID="cblFavFruits" runat="server">
                <asp:ListItem Value="Apple">Apple</asp:ListItem>
                 <asp:ListItem Value="Mango">Mango</asp:ListItem>
                 <asp:ListItem Value="Banana">Banana</asp:ListItem>
                 <asp:ListItem Value="Grapes">Grapes</asp:ListItem>
            </asp:CheckBoxList>--%>
            <asp:Button ID="btnSaveFavFruits" 
                CssClass="btn btn-primary"
                runat="server" Text="Save" OnClick="btnSaveFavFruits_Click" />

            <asp:Label ID="lblSelection" runat="server" />
            </asp:Panel>
            <asp:Button ID="Button1" runat="server" Text="Toggle Visibilty" OnClick="Button1_Click" />
             <asp:Button ID="Button2" runat="server" Text="Toggle Disable" OnClick="Button2_Click" style="height: 35px" />
        </div>
    </form>
</body>
</html>
