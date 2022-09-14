<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataControlsPage2.aspx.cs" Inherits="ASPNETData.DataControlsPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Repeater  ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="card m-4" style="width:300px;">
                          <img src="<%# Eval("ImageUrl") %>" 
                              class="card-img-top" alt="...">
                          <div class="card-body">
                            <p class="card-text"><%# Eval("Name") %></p>
                          </div>
                        </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
