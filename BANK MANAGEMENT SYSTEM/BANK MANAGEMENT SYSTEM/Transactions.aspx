<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="BANK_MANAGEMENT_SYSTEM.Transactions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="text-align:center;" >
       <h1 >Transaction Details</h1>
        <div style="border:2px;  text-align:center;margin-left:auto;margin-right:auto;background-color:navy;color:white;border-radius:20px;padding:20px;margin-top:5%;text-align:center" >
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left:auto;margin-right:auto"></asp:GridView>
        </div>
        <div style="border:2px;  text-align:center;margin-left:auto;margin-right:auto;background-color:navy;color:white;border-radius:20px;padding:20px;margin-top:5%;text-align:center" >
            <h1 >User Details</h1>
            <asp:Button ID="cnt" runat="server" Text="Get Count" Style="float: right" OnClick="cnt_Click" />
            <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="margin-left:auto;margin-right:auto"></asp:GridView>
        </div>
    </form>
</body>
</html>
