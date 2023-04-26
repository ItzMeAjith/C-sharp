<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_Disconnected.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:GridView runat="server" AutoGenerateColumns="False" ID="GridView1">
            <Columns>
                <asp:BoundField DataField="Rollno" HeaderText="Roll No" SortExpression="Rollno"></asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                <asp:BoundField DataField="Dept" HeaderText="Department" SortExpression="Dept"></asp:BoundField>
                <asp:BoundField DataField="CGPA" HeaderText="CGPA" SortExpression="CGPA"></asp:BoundField>

            </Columns>
        </asp:GridView>
        <br />
        <br />
        <div>
            <asp:Label runat="server" Text="Enter Dept"></asp:Label>
            <asp:TextBox runat="server" ID="dept"></asp:TextBox><asp:Button runat="server" Text="Search" OnClick="Unnamed3_Click"></asp:Button>

        </div>
        <br />
        <br />
        <div>
             <asp:GridView runat="server" AutoGenerateColumns="False" ID="GridView2" >
            <Columns>
                <asp:BoundField DataField="Rollno" HeaderText="Roll No" SortExpression="Rollno"></asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                <asp:BoundField DataField="Dept" HeaderText="Department" SortExpression="Dept"></asp:BoundField>
                <asp:BoundField DataField="CGPA" HeaderText="CGPA" SortExpression="CGPA"></asp:BoundField>

            </Columns>
        </asp:GridView>
        </div>

    </form>
</body>
</html>
