<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pilhaComStatic.aspx.cs" Inherits="Paginas_Estudo_para_prova_pilhaComStatic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt" runat="server"></asp:TextBox>
            <asp:Button ID="btnadd" runat="server" Text="Adicionar" OnClick="btnadd_Click"/>
            <asp:Button ID="btnrem" runat="server" Text="Remover" OnClick="btnrem_Click"/>
            <asp:Button ID="btnexplodir" runat="server" Text="Explodir" OnClick="btnexplodir_Click" />
            <asp:Literal ID="ltr" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
