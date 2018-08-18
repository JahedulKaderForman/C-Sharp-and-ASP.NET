<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseInfoUI.aspx.cs" Inherits="WebAppExamBitm.UI.CourseInfoUI" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxCode" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Course Name"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="TextBoxCourseName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Credit"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBoxCredit" runat="server"></asp:TextBox>
                    </td>
                </tr>
               <tr>
                <td>
                   
                </td>
                <td>
                    <asp:Button ID="ButtonSave" runat="server" Text="Save" Width="128px" OnClick="SaveButtonClick"/>
                </td>
            </tr>
                <tr>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
