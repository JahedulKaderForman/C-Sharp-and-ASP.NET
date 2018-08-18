<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RadioButtonApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <fieldset style="width:300px">
            <legend>Gender</legend>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" AutoPostBack="True" GroupName="Gender" OnCheckedChanged="RadioButton1_CheckedChanged" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="Gender" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Unknown" GroupName="Gender" />
        </fieldset>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server"  NavigateUrl="www.google.com" Target="_blank">Google</asp:HyperLink>
        </p>
    </form>
</body>
</html>
