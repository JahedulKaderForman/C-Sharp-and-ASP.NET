<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SalaryApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Basic Salary"></asp:Label>
            <asp:TextBox ID="TextBoxBasic" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="tk"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="MedicalAllowance"></asp:Label>
            <asp:TextBox ID="TextBoxMedical" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="%"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="HouseRent"></asp:Label>
            <asp:TextBox ID="TextBoxHouse" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="%"></asp:Label>
            
        </div>
        <asp:Button ID="Button1" runat="server" Text="Show" OnClick="showButtonClick" /><br />
        <asp:Label ID="Label7" runat="server" Text="Total Salary"></asp:Label><br />
        <asp:Label ID="showSalary" runat="server"></asp:Label>
    </form>
</body>
</html>
