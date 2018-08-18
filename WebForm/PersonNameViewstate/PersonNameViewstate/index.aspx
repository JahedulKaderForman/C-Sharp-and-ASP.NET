<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PersonNameViewstate.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
            <tr>
             <td>
            <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
            </td>
             <td>
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
              </td>
             </tr>

            <tr>
             <td>
            <asp:Label ID="Label2" runat="server" Text="MiddleName"></asp:Label>
            </td>
             <td>
            <asp:TextBox ID="TextBoxMiddle" runat="server"></asp:TextBox>
              </td>
             </tr>

            <tr>
             <td>
            <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
                
            </td>
             <td>
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
              </td>
             </tr>



                </table>


        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="saveButtonClick" />
        <asp:Button ID="Button2" runat="server" Text="Show" OnClick="showButtonClick" /><br />
        <asp:ListBox ID="ListBoxshow" runat="server" Height="228px" Width="236px"></asp:ListBox>
    </form>
</body>
</html>
