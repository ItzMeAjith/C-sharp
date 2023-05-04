<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_to_SQL_28_04.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Roll" runat="server" Text="Select Roll number"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Rollno" DataValueField="Rollno" DataSourceID="SqlDataSource1"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:CIETConnectionString %>" SelectCommand="SELECT [Rollno] FROM [Clg_Depts]"></asp:SqlDataSource>
            <asp:Button ID="Fnd" runat="server" Text="Find" OnClick="Fnd_Click" />
            <textarea id="TextArea1" runat="server" cols="50" rows="2"></textarea>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
