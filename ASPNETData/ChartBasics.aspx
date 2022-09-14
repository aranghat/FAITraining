<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartBasics.aspx.cs" Inherits="ASPNETData.ChartBasics" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Chart ID="Chart1" runat="server" DataSourceID="sqlOrderStatus">
                <series>
                    <asp:Series ChartType="Pie" Name="Series1" XValueMember="DeliveryStatus" YValueMembers="TotalCount">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="sqlOrderStatus" runat="server" ConnectionString="<%$ ConnectionStrings:SREE_EMPLOYEEDBConnectionString %>" SelectCommand="SELECT [DeliveryStatus],COUNT(*) AS TotalCount FROM [VW_ORDER_DETAILS]
GROUP BY DeliveryStatus"></asp:SqlDataSource>
        </div>
        <asp:Chart ID="Chart2" runat="server" DataSourceID="sqlProductOrderStatus" Palette="EarthTones">
            <series>
                <asp:Series Legend="Legend1" Name="Series1" XValueMember="Name" YValueMembers="TotalOrders">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisY Title="Total Orders">
                    </AxisY>
                    <AxisX Title="Products" Url="Default.aspx">
                    </AxisX>
                    <Area3DStyle Enable3D="True" />
                </asp:ChartArea>
            </chartareas>
            <Legends>
                <asp:Legend Name="Legend1">
                </asp:Legend>
            </Legends>
        </asp:Chart>
        <asp:SqlDataSource ID="sqlProductOrderStatus" runat="server" ConnectionString="<%$ ConnectionStrings:SREE_EMPLOYEEDBConnectionString %>" SelectCommand="SELECT P.Name,COUNT(*) AS TotalOrders FROm Products P
JOIN Orders O ON O.ProductId = P.ID
GROUP BY P.Name"></asp:SqlDataSource>
    </form>
</body>
</html>
