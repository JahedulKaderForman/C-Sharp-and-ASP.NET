<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AccountWebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Account_Info</legend>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Account_No"></asp:Label>
            <asp:TextBox ID="TextBoxAccountNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="CustomerName"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="CreatButton" runat="server" Text="Create" OnClick="createAccount" />
        </p>
        </fieldset>

        <fieldset>
            <legend>Trancation</legend>
        <asp:Label ID="Label3" runat="server" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="TextBoxAmount" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Deposite" OnClick="DepositeButton" />
            <asp:Button ID="Button3" runat="server" Text="Withdraw" OnClick="withdrawButton" />
        </p>

        </fieldset>
        <asp:Button ID="Button4" runat="server" Text="Report" OnClick="reportButton" />
        <asp:Label ID="showBalance" runat="server" Text="showBalance"></asp:Label>
    </form>
</body>
</html>
