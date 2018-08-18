<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ItemPriceViewState.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Total Item"></asp:Label>
            <asp:TextBox ID="TextBoxItem" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Label2" runat="server" Text="Unit Price"></asp:Label>
        <asp:TextBox ID="TextBoxPrice" runat="server"></asp:TextBox>
        </br>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="saveButtonClick" />
        </br>
         </br>
        <asp:Button ID="Button2" runat="server" Text="Show" OnClick="showButtonClick" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Total Price"></asp:Label>
           
            <asp:Label ID="TotalPrice" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
