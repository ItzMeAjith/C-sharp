<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Application_Form.aspx.cs" Inherits="BANK_MANAGEMENT_SYSTEM.Application_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align:center;">
        <h1 >Account Opening Application</h1>
        <div style="border:2px; width:400px; text-align:center;margin-left:auto;margin-right:auto;background-color:navy;color:white;border-radius:20px;padding:20px;margin-top:4%">
            <h3>Signup</h3>
        <asp:Label ID="label1" runat="server" Text="Enter User ID"></asp:Label> <br />
        <input id="A_usrID" type="text" runat="server"/><br /> <br />
        <asp:Label ID="label3" runat="server" Text="Enter Name"></asp:Label> <br />
        <input id="A_name" type="text" runat="server"/><br /> <br />
            <asp:Label ID="label7" runat="server" Text="Select Gender"></asp:Label> <br />
            <select id="F_gen" runat="server">
                <option runat="server">Male</option>
                <option runat="server">Female</option>
            </select><br /> <br />
            <asp:Label ID="label4" runat="server" Text="Enter Phone No"></asp:Label> <br />
        <input id="A_phone" type="text" runat="server"/><br /> <br />
        <asp:Label ID="Label2" runat="server" Text="Enter Mail ID"></asp:Label> <br />
        <input id="A_mailid" type="text" runat="server" /><br /> <br />
            <asp:Label ID="Label5" runat="server" Text="Enter Date of Birth"></asp:Label> <br />
        <input id="A_DOB" type="date" runat="server" /><br /> <br />
            <asp:Label ID="Label6" runat="server" Text="Upload Photograph"></asp:Label> <br /><br />
        <input id="A_pic" type="file" runat="server" /><br /> <br />
            <asp:Label ID="Label8" runat="server" Text="Enter Address"></asp:Label> <br />
        <input id="A_Addr" type="text" runat="server" /><br /> <br />
        <asp:Button ID="Submit" runat="server" Text="Submit"  style="cursor:pointer;font-weight:600" OnClick="Submit_Click"/>
        </div>
    </form>
</body>
</html>
