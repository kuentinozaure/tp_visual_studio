<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormServiceCalculatorConsumer.aspx.cs" Inherits="WebServiceConsumer.WebFormServiceCalculatorConsumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt_p1" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_p2" runat="server"></asp:TextBox>
        </div>
        <hr />
        <asp:Button ID="btn_divide" runat="server" OnClick="btn_divide_Click" Text="Divide" />
        <hr />
        <asp:Button ID="btn_multiply" runat="server" OnClick="btn_multiply_Click" Text="Multiply" />
        <hr />
        <asp:Button ID="btn_substract" runat="server" OnClick="btn_substract_Click" Text="Substract" />
        <hr />
        <asp:Label ID="lbl_result" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
