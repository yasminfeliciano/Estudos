<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_Session.aspx.cs" Inherits="ProjectASPNet.WebControls_Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <style type="text/css">  
        .auto-style1 {  
            width: 100%;  
        }  
        .auto-style2 {  
            width: 105px;  
        }  
    </style>  

</head>
<body>
    <form id="form1" runat="server">
    <p>Provide Following Details</p>  
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">Email</td>  
            <td>  
                <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2"> </td>  
            <td>  
                <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />  
            </td>  
        </tr>  
    </table>  
    <br />  
    <asp:Label ID="Label3" runat="server"></asp:Label>  
    <br />  
    <asp:Label ID="Label4" runat="server"></asp:Label>  

    </form>
</body>
</html>
