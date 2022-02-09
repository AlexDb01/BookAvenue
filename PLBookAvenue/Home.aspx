<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PLBookAvenue.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblHome" runat="server"></asp:Label>
        </div>
        <asp:Button ID="btnAdmin" runat="server" Text="Admin" />
        <br />
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="LogOut" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Year"></asp:Label>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Pages"></asp:Label>
        <asp:TextBox ID="txtPages" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Genre"></asp:Label>
        <asp:TextBox ID="txtGenre" runat="server"></asp:TextBox>
        <br />
        <br />

         <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" />
        <br />
<hr />
<asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound">
    <Columns>
       <asp:BoundField DataField="title" HeaderText="Title" />
        <asp:BoundField DataField="year" HeaderText="Year" />
        <asp:BoundField DataField="author" HeaderText="Author" />
        <asp:BoundField DataField="pages" HeaderText="Pages" />
        <asp:BoundField DataField="type" HeaderText="Genre" />
        <asp:BoundField DataField="bookID" HeaderText="BookID" />
        <asp:BoundField DataField="contentType" HeaderText="Content Type" />
        <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
                <asp:Image width="200" height="300" ID="Image1" runat="server"  />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<div id="dialog" style="display: none">
</div>
    </form>
</body>
</html>
