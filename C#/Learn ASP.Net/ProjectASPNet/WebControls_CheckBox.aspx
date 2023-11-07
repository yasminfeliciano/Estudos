<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_CheckBox.aspx.cs" Inherits="ProjectASPNet.WebControls_CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select Courses</h2>  
            <asp:CheckBox ID="CheckBox1" runat="server" Text="J2SE" />  
            <asp:CheckBox ID="CheckBox2" runat="server" Text="J2EE" />  
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Spring" />  
        </div>  
        <p>  
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />  
        </p>  
    </form>  
    <p>  
        Courses Selected: <asp:Label runat="server" ID="ShowCourses"></asp:Label>  
    </p>  

</body>
</html>
