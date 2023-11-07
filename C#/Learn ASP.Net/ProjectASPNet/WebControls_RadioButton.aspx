<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_RadioButton.aspx.cs" Inherits="ProjectASPNet.WebControls_RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />  
        </div>  
        <p>  
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="width: 61px" />  
        </p>  
    </form>  
    <asp:Label runat="server" id="genderId"></asp:Label>  

</body>
</html>
