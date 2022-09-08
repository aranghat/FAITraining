<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="HelloWeb.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fuPhotos" runat="server"
                 accept="image/png, image/gif, image/jpeg"
                />
            <asp:Button ID="btnUpload" runat="server"
                Text="Upload" 
                 
                OnClick="btnUpload_Click" />
            <asp:Image ID="Image1" runat="server" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
