<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_DropDownList.aspx.cs" Inherits="ProjectASPNet.WebControls_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>New Delhi</asp:ListItem>
                <asp:ListItem>Greater Noida</asp:ListItem>
                <asp:ListItem>New York</asp:ListItem>
                <asp:ListItem>Paris</asp:ListItem>
                <asp:ListItem>London</asp:ListItem>
            </asp:DropDownList>
        </div>
        <br />  
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />  
        <br />  
        <br />  
        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label>  

    </form>
</body>
</html>
