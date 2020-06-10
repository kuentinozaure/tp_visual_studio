<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormServiceConsumer.aspx.cs" Inherits="WebServiceConsumer.WebFormServiceConsumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btn_hello_world" runat="server" OnClick="Button1_Click" Text="Hello world" />
        </p>
        <p>
            <asp:Label ID="lbl_hello_world" runat="server" Text="Label"></asp:Label>
        </p>
        <hr />
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        <asp:Button ID="btn_hello_name" runat="server" OnClick="btn_hello_name_Click" Text="Hello + name" />
        <asp:Label ID="lbl_hello_name" runat="server" Text="Label"></asp:Label>
        <hr />
        <asp:TextBox ID="txt_p1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txt_p2" runat="server"></asp:TextBox>
        <asp:Label ID="lbl_add" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btn_add" runat="server" OnClick="Button1_Click2" Text="Add" />
    </form>
</body>
</html>
