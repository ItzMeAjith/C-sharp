<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bank_Home.aspx.cs" Inherits="BANK_MANAGEMENT_SYSTEM.Bank_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>

<body style="background-color:cornflowerblue">
    <form id="form1" runat="server">
        <div style="text-align:center">
            <asp:Button ID="home" runat="server" Text="Home" OnClick="home_Click" />
            <asp:Button ID="appform" runat="server" Text="Application Form" OnClick="appform_Click" />
            <asp:Button ID="fundTrans" runat="server" Text="Fund Transfer" OnClick="fundTrans_Click" />
            <asp:Button ID="transact" runat="server" Text="Transactions" OnClick="transact_Click" />
            <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
            <asp:Button ID="go" runat="server" Text="GO" Style="float: right" OnClick="go_Click" />
            <input ID="sear" type="search" placeholder="Search by AccNo" runat="server" style="float:right"/>
        </div>
        <div style="text-align:center;margin-top:12%">
            <h1>WELCOME TO OUR BANK!!!!</h1>
            <asp:GridView ID="USertbl" runat="server" style="margin-left:auto;margin-right:auto"></asp:GridView>
        </div>
    </form>
</body>
</html>
