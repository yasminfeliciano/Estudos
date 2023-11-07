<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_LinkButton.aspx.cs" Inherits="ProjectASPNet.WebControls_LinkButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>It is a hyperlink style button</p>  
        </div>  
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">skyapper</asp:LinkButton>  
        <p>  
            <asp:Label ID="Label1" runat="server"></asp:Label>  
        </p>  

    </form>
</body>
</html>
