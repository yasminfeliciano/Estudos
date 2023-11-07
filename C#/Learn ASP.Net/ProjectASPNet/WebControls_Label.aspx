﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_Label.aspx.cs" Inherits="ProjectASPNet.WebControls_Label" %>

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
	margin-left: 0px;
}
.auto-style3 {
	width: 121px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h4>Provide the Following Details:</h4>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Label ID="Label2" runat="server" Text= "Upload a File"></asp:Label></td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat= "server" /></td>
                    </tr>
                </table>
        </div>
    </form>
</body>
</html>
