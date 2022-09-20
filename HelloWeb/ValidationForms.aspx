<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationForms.aspx.cs" Inherits="HelloWeb.ValidationForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                runat="server" 
                 ErrorMessage="Please Provide a Valid User Name"
                 ForeColor="Red"
                 ControlToValidate="txtUserName"
                 Display="Dynamic"
                ></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                ControlToValidate="txtUserName"
                 ValidationExpression="^[a-zA-Z]+$"
                runat="server" 
                Display="Dynamic"
                ErrorMessage="Only alphabets are allowd"></asp:RegularExpressionValidator>

            <br />
            <asp:TextBox ID="txtPassword" Placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
             <asp:TextBox ID="txtConfirmPassword" Placeholder="Confirm Password" TextMode="Password" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" 
                 ControlToValidate="txtConfirmPassword"
                 ControlToCompare="txtPassword"
                 Type="="
                            runat="server" 
                 Display="Dynamic"
                ErrorMessage="Password and Confirm Password is not same"></asp:CompareValidator>
           
            <asp:TextBox ID="txtEnterTheAmount" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" 
                ControlToValidate="txtEnterTheAmount"
                MinimumValue="100"
                MaximumValue="1000"
                runat="server" 
                ForeColor="Red"
                Type="Integer"
                ErrorMessage="The Value mus be between 1000 to 10000"></asp:RangeValidator>

            <asp:TextBox ID="txtTestPassword" runat="server"></asp:TextBox>

            <asp:Button ID="btnSave" runat="server" Text="Save" />
            <asp:CustomValidator ID="CustomValidator1" runat="server" 
                 ControlToValidate="txtTestPassword"
                ErrorMessage="Password must be atleast 4 chars and must contain number and special chars" 
                OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        </div>
    </form>
</body>
</html>
