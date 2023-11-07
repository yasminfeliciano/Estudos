<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_CookieExample.aspx.cs" Inherits="ProjectASPNet.WebControls_CookieExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Select Brand Preferences"></asp:Label>  
    <br />  
    <br />  
    <asp:CheckBox ID="apple" runat="server" Text="Apple" />  
    <br />  
    <asp:CheckBox ID="dell" runat="server" Text="Dell" />  
    <br />  
    <asp:CheckBox ID="lenevo" runat="server" Text="Lenevo" />  
    <br />  
    <asp:CheckBox ID="acer" runat="server" Text="Acer" />  
    <br />  
    <asp:CheckBox ID="sony" runat="server" Text="Sony" />  
    <br />  
    <asp:CheckBox ID="wipro" runat="server" Text="Wipro" />  
    <br />  
    <br />  
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
    <p>  
        <asp:Label ID="Label2" runat="server"></asp:Label>  
    </p>  

    </form>
</body>
</html>
