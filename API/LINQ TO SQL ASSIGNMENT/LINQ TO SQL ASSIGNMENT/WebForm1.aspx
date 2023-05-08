<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LINQ_TO_SQL_ASSIGNMENT.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:auto;margin-right:auto;width:800px;padding:10px ;border-radius:10px;background-color:darkblue;text-align:center;color:white" >
            <h1 >Registration form</h1>

            <asp:Label ID="Label2" runat="server" Text="Enter name : "></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label3" runat="server" Text="Enter Phone number : "></asp:Label>
            <asp:TextBox ID="phone" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label4" runat="server" Text="Enter Email ID : "></asp:Label>
            <asp:TextBox ID="mail" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label5" runat="server" Text="Enter address : "></asp:Label>
            <asp:TextBox ID="address" runat="server" OnTextChanged="address_TextChanged"></asp:TextBox><br /><br />         

            <asp:Label ID="Label7" runat="server" Text="Enter blood group : "></asp:Label>
            <asp:TextBox ID="bgroup" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label1" runat="server" Text="Enter date of birth (yyyy/mm/dd) : "></asp:Label>
            <asp:TextBox ID="DOB" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Label8" runat="server" Text="Enter department ID : "></asp:Label>
            <asp:TextBox ID="DEP" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click" /><br /><br />
            <asp:Label ID="Label6" runat="server" Text="Select Roll number to update : "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Rollno" DataValueField="Rollno" DataSourceID="SqlDataSource1"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:CIETConnectionString %>" SelectCommand="SELECT [Rollno] FROM [Clg_Depts]"></asp:SqlDataSource>
             <asp:Button ID="Update" runat="server" Text="Update"/><br /><br /><br />

             <asp:Label ID="Label10" runat="server" Text="Select the department ID to filter : "></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="DeptID" DataValueField="DeptID" DataSourceID="SqlDataSource2"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="<%$ ConnectionStrings:CIETConnectionString %>" SelectCommand="SELECT [DeptID] FROM [Department]"></asp:SqlDataSource>
            
            
            <asp:Button ID="Filter" runat="server" Text="Filter" OnClick="Filter_Click" /><br /><br /><br />
            <asp:GridView ID="GridView2" runat="server"></asp:GridView><br /><br />


           
            <div>
             <asp:Label ID="Label9" runat="server" Text="Enter the roll no to delete"></asp:Label>
            <asp:TextBox ID="Del" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView><br />
                <asp:Button ID="Fetch" runat="server" Text="Fetch data" OnClick="Fetch_Click" />

        </div>
        </div>
        
    </form>
</body>
</html>
