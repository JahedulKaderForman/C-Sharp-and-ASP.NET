<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCourseUI.aspx.cs" Inherits="WebAppExamBitm.UI.SearchCourseUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <asp:RadioButton id="searchByCode" runat="server" GroupName="SearchCourse" Text="Search By Code"></asp:RadioButton>
    <asp:RadioButton id="SearchByName" runat="server" GroupName="SearchCourse" Text="Search By Name"></asp:RadioButton>
    </div>
        <table>
             <tr>
                <td>
                   <asp:TextBox ID="TextBoxSearch" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Search" Width="128px" OnClick="SearchButtonClick"   />
                </td>
            </tr>
        </table>

        <asp:GridView ID="GridViewCourse" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                     <HeaderTemplate> Serial No.</HeaderTemplate>
                 <ItemTemplate>
                   <%#Container.DataItemIndex+1 %>
                 </ItemTemplate>
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                      <asp:Label ID="codeId" runat="server" Text='<%# Eval("Code") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CourseName">
                    <ItemTemplate>
                       <asp:Label ID="courseId" runat="server" Text='<%# Eval("CourseName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                       <asp:Label ID="descritionId" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Credit">
                    <ItemTemplate>
                       <asp:Label ID="creditId" runat="server" Text='<%# Eval("Credit") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
