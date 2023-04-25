<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Registration.aspx.cs" Inherits="BANK_MANAGEMENT_SYSTEM.User_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:cornflowerblue">
    <form id="form1" runat="server" style="text-align:center;">
        <h1 >USER REGISTRATION</h1>
        <div style="border:2px; width:400px; text-align:center;margin-left:auto;margin-right:auto;background-color:navy;color:white;border-radius:20px;padding:20px;margin-top:12%">
            <h3>Signup</h3>
        <asp:Label ID="label1" runat="server" Text="Enter User ID"></asp:Label> <br />
        <input id="usrID" type="text" runat="server"/><br /> <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Mail ID"></asp:Label> <br />
        <input id="mailid" type="text" runat="server" /><br /> <br />
        <asp:Label ID="Label3" runat="server" Text="Enter Password"></asp:Label> <br />
        <input id="psword" type="password" runat="server"/><br /> <br />
        <asp:Button ID="Submit" runat="server" Text="Signup"  style="cursor:pointer;font-weight:600" OnClick="Submit_Click"/>
        </div>
    </form>
</body>
</html>
