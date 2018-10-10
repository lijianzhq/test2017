<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostFileToFTP.aspx.cs" Inherits="TestUploadFile.PostFileToFTP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txt_FilePath"></asp:TextBox>
            <br />
            <asp:Button runat="server" Text="发送本地文件到ftp" OnClick="Unnamed_Click" />
            <asp:Button runat="server" Text="发送本地文件到ftp（流方式）" OnClick="Unnamed_Click1" />
        </div>
    </form>
</body>
</html>
