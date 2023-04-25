<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fund_Transfer.aspx.cs" Inherits="BANK_MANAGEMENT_SYSTEM.Fund_Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:cornflowerblue">
    <form id="form1" runat="server" style="text-align:center;">
        <h1 >FUND TRANSFER</h1>
        <div style="border:2px; width:400px; text-align:center;margin-left:auto;margin-right:auto;background-color:navy;color:white;border-radius:20px;padding:20px;margin-top:12%">
            <h3>Quick Transfer</h3>
        <asp:Label ID="label1" runat="server" Text="Enter Account Number"></asp:Label> <br />
        <input id="F_Accno" type="text" runat="server"/><br /> <br />
        <asp:Label ID="label2" runat="server" Text="Select Action"></asp:Label> <br />
            <select id="F_Action" runat="server">
                <option runat="server">Credit</option>
                <option runat="server">Debit</option>
            </select><br /> <br />
             <asp:Label ID="label3" runat="server" Text="Enter Amount"></asp:Label> <br />
            <input id="F_Amount" type="text" runat="server"/><br /> <br />
            <asp:Button ID="F_sub" runat="server" Text="Proceed" OnClick="F_sub_Click" />

        </div>
    </form>
</body>
</html>
