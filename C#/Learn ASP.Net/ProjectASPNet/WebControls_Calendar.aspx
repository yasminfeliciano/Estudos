<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_Calendar.aspx.cs" Inherits="ProjectASPNet.WebControls_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Select Date from the Calender</h2>  
        <div>  
            <asp:Calendar ID="Calendar1" runat="server"  OnSelectionChanged="Calendar1_SelectiChanged"></asp:Calendar>  
        </div>  
    </form>  
    <p>  
        <asp:Label runat="server" ID="ShowDate" >

        </asp:Label>  
    </p>  

</body>
</html>
