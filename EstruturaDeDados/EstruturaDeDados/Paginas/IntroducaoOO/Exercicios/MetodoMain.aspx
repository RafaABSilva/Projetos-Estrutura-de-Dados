<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MetodoMain.aspx.cs" Inherits="Paginas_IntroducaoOO_Exercicios_Palindromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body class="jumbotron">
    <form id="form1" runat="server">
        <div class="row text-center">
            <div class="col-md-12">
                <h1 class="m-4">Palíndromo</h1>
            </div>
        </div>
        <div class="row text-center">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <asp:TextBox ID="textEntrada" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <asp:Literal ID="saida" runat="server"></asp:Literal>
            </div>
        </div>

        <div class="row text-center">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <asp:Button ID="btn" runat="server" Text="Envar" CssClass="btn btn-success m-2" OnClick="btn_Click" />
            </div>
            <div class="col-md-4"></div>
        </div>
    </form>
</body>
</html>
