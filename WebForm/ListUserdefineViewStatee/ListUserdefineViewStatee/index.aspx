<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ListUserdefineViewStatee.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Student Name"></asp:Label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:Label ID="Label2" runat="server" Text="Reg No"></asp:Label>
            <asp:TextBox ID="TextBoxRegNo" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="saveButtonClick" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="show" OnClick="showButtonClick" />
        </p>
        <div>
            <asp:Label ID="Label4" runat="server" Text="StudentList"></asp:Label>
           
        </div>

        <div>
            <asp:ListBox ID="ListBoxshow" runat="server" Height="251px" Width="237px"></asp:ListBox>
           
        </div>

        <div>
           
        </div>
    </form>
</body>
</html>
