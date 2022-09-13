<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPNETData.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-iYQeCzEYFbKjA/T2uDLTpkwGzCiq6soy8tYaI1GyVh/UjpbCx/TYkiZhlZB6+fzT" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-u1OknCvxWvY5kfmNBILK2hRnQC3Pr17a+RTT6rIHI7NnikvbZlHgTPOOmMi466C8" crossorigin="anonymous"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div>
            <asp:FormView ID="FormView1" runat="server" AllowPaging="True" CssClass="card m-4" CellPadding="3" CellSpacing="2" DataKeyNames="ID" DataSourceID="sqlCommerce" GridLines="Both">
                <EditItemTemplate>
                    ID:
                    <asp:Label ID="IDLabel1" runat="server" Text='<%# Eval("ID") %>' />
                    <br />
                    Name:
                    <asp:TextBox  ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    TotalStock:
                    <asp:TextBox ID="TotalStockTextBox" runat="server" Text='<%# Bind("TotalStock") %>' />
                    <br />
                    UnitPrice:
                    <asp:TextBox ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
               
                <InsertItemTemplate>
                    <div class="card-body">
                   <table class="table">
                       <thead>
                           <tr>
                               <th>NAME</th>
                               <th>TOTAL STOCK</th>
                               <th>UNIT PRICE</th>
                           </tr>
                       </thead>
                       <tbody>
                           <tr>
                               <td> <asp:TextBox CssClass="form-control" ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' /></td>
                               <td><asp:TextBox CssClass="form-control" ID="TotalStockTextBox" runat="server" Text='<%# Bind("TotalStock") %>' /></td>
                               <td> <asp:TextBox CssClass="form-control" ID="UnitPriceTextBox" runat="server" Text='<%# Bind("UnitPrice") %>' /></td>
                           </tr>
                       </tbody>
                   </table>
                        </div>
                    <div class="card-footer">
                         <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" CssClass="btn btn-primary" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CssClass="btn btn-danger" CommandName="Cancel" Text="Cancel" />
                    </div>
                   
                </InsertItemTemplate>
                <ItemTemplate>
                    <div class="card-body">
                        <table class="table">
                            <tbody>
                                <tr>
                                    <td>ID</td>
                                    <td><asp:Label ID="IDLabel" runat="server" Text='<%# Eval("ID") %>' /></td>
                                </tr>
                                 <tr>
                                    <td>NAME</td>
                                    <td><asp:Label ID="NameLabel" runat="server" Text='<%# Bind("Name") %>' /></td>
                                </tr>
                                 <tr>
                                    <td>Total Stock</td>
                                    <td> <asp:Label ID="TotalStockLabel" runat="server" Text='<%# Bind("TotalStock") %>' /></td>
                                </tr>
                                 <tr>
                                    <td>Unit Price</td>
                                    <td><asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Bind("UnitPrice") %>' /></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                   
                    <asp:LinkButton ID="EditButton" CssClass="btn btn-primary" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                    <asp:LinkButton ID="NewButton" CssClass="btn btn-primary" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                    <asp:LinkButton ID="DeleteButton" CssClass="btn btn-danger" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                    
                </ItemTemplate>
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
               
            </asp:FormView>
            <asp:SqlDataSource ID="sqlCommerce" runat="server" ConnectionString="<%$ ConnectionStrings:SREE_EMPLOYEEDBConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Products] ([Name], [TotalStock], [UnitPrice]) VALUES (@Name, @TotalStock, @UnitPrice)" SelectCommand="SELECT [ID], [Name], [TotalStock], [UnitPrice] FROM [Products]" UpdateCommand="UPDATE [Products] SET [Name] = @Name, [TotalStock] = @TotalStock, [UnitPrice] = @UnitPrice WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="TotalStock" Type="Int32" />
                    <asp:Parameter Name="UnitPrice" Type="Double" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="TotalStock" Type="Int32" />
                    <asp:Parameter Name="UnitPrice" Type="Double" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
