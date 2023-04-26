<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQL_to_linq_Assignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1 style="text-align:center">Student's Attendance</h1>
            <asp:Label runat="server" Text="Enter Roll no"></asp:Label>
            <asp:TextBox runat="server" ID ="roll"></asp:TextBox><br /> <br />
            <asp:Label runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox runat="server" ID ="name"></asp:TextBox><br /> <br />
            <asp:Label runat="server" Text="select Department"></asp:Label>
            <asp:DropDownList runat="server" DataTextField="DeptID" DataValueField="DeptID" DataSourceID="SqlDataSource1" ID="select"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="Data Source=DESKTOP-GL7RKG7\SQLEXPRESS;Initial Catalog=CIET;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [DeptID] FROM [Department]"></asp:SqlDataSource>
               
            <br /> <br />
            <asp:Button runat="server" Text="Insert" ID="insert" OnClick="insert_Click"></asp:Button>
        </div><br /> <br />
        <div>
            <asp:GridView runat="server" ID="Gridview1"></asp:GridView>
        </div>
    </form>
</body>
</html>
