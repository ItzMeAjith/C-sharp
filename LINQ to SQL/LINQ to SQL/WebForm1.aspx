﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_to_SQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged"></asp:GridView> <br /><br />
            <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged"></asp:GridView>
        </div>
    </form>
</body>
</html>
