<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:GridView runat="server" AutoGenerateColumns="False" ID="ctl02" OnSelectedIndexChanged="ctl02_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Rollno" HeaderText="Roll No" SortExpression="Rollno"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="Dept" HeaderText="Department" SortExpression="Dept"></asp:BoundField>
            <asp:BoundField DataField="CGOA" HeaderText="CGPA" SortExpression="CGPA"></asp:BoundField>
                
        </Columns>
    </asp:GridView>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
