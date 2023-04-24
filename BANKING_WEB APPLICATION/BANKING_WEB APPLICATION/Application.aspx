<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="BANKING_WEB_APPLICATION.Application" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Label ID="Label" runat="server" Text="Enter User ID : "></asp:Label>
            <asp:TextBox ID="UserID" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label1" runat="server" Text="Enter Name : "></asp:Label>
            <asp:TextBox ID="name12" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label2" runat="server" Text="Enter Date of Birth : "></asp:Label>
            <asp:TextBox ID="DOB" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label3" runat="server" Text="Enter Phone number : "></asp:Label>
            <asp:TextBox ID="phone12" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label4" runat="server" Text="Enter mailID : "></asp:Label>
            <asp:TextBox ID="mail12" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label5" runat="server" Text="Enter Address : "></asp:Label>
            <asp:TextBox ID="address12" runat="server"></asp:TextBox><br /> <br/>
            <asp:Label ID="Label6" runat="server" Text="Upload photo : "></asp:Label>
            <asp:FileUpload ID="pic" runat="server" />
            <asp:Button ID="Sub" runat="server" Text="Submit" OnClick="Sub_Click" />
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:GridView ID="gri1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
