<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="Time_Management_System_Project.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="UserName" runat="server" Text="User Name"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox> <br />
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="pass" runat="server"></asp:TextBox><br /> <br />
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>

        </div>
    </form>
</body>
</html>
