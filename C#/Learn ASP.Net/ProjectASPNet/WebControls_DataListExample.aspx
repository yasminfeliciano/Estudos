<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebControls_DataListExample.aspx.cs" Inherits="ProjectASPNet.WebControls_DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">  
            <ItemTemplate>  
                name:  
                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />  
                <br />  
                email:  
                <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />  
                <br />  
                contact:  
                <asp:Label ID="contactLabel" runat="server" Text='<%# Eval("contact") %>' />  
                <br />  
     <br />  
            </ItemTemplate>  
        </asp:DataList>  
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>"   
        SelectCommand="SELECT * FROM [student]"></asp:SqlDataSource>  

    </form>
</body>
</html>
