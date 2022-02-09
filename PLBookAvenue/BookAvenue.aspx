<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookAvenue.aspx.cs" Inherits="PLBookAvenue.BookAvenue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br/>
        </div>
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:Label ID="lblUsername" runat="server" Text="username"></asp:Label>
                <asp:TextBox ID="txtUsernameLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblPassword" runat="server" Text="password"></asp:Label>
                <asp:TextBox ID="txtPasswordLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
                <br />
                <br />
                <asp:Label ID="lblUsername0" runat="server" Text="username"></asp:Label>
                <asp:TextBox ID="txtUsernameRegister" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="lblPassword0" runat="server" Text="password"></asp:Label>
                <asp:TextBox ID="txtPasswordRegister" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnRegister" runat="server" Text="Register" />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
