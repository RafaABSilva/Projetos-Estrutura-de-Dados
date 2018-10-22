<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pilha.aspx.cs" Inherits="Paginas_IntroducaoOO_Pilha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="jumbotron">
    <form id="form1" runat="server">
        <div class="row text-center">
            <div class="col-md-12">
                <h1>Pilha</h1>
            </div>
        </div>
        <div class="row text-center">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <asp:TextBox ID="txtNomes" CssClass="form-control" placeholder="Digite um nome" runat="server"></asp:TextBox>
                <br />
            </div>
            <div class="col-md-4"></div>
        </div>
        <div class="row text-center">
            <div class="col-md-12">
                <asp:Button ID="btnAdd" runat="server" CssClass="btn btn-success" Text="Adicionar na Fila" OnClick="btnAdd_Click" />

                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnTopo" runat="server" CssClass="btn btn-info" Text="Topo da Fila" OnClick="btnTopo_Click" />

                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnVerFila" runat="server" CssClass="btn btn-warning" Text="Ver Fila" OnClick="btnVerFila_Click" />

                &nbsp;&nbsp;&nbsp;
                <a href="#" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal">Zerar Fila</a>

                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRetirar" runat="server" CssClass="btn btn-danger" Text="Retirar da Fila" OnClick="btnRetirar_Click" />
            </div>
        </div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-4">
                <br />
                <asp:Literal ID="lblMostrar" runat="server"></asp:Literal>
                <asp:Literal ID="lblQtd" runat="server"></asp:Literal>
            </div>
            <div class="col-md-4"></div>

            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            Você deseja Apagar tudo?
                        </div>
                        <div class="modal-footer">
                            <a class="btn btn-secondary" data-dismiss="modal">Fechar</a>
                            <asp:Button ID="btnZerarFila" runat="server" CssClass="btn btn-danger" Text="Zerar Fila" OnClick="btnZerarFila_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <script src="../../Scripts/jquery-3.0.0.min.js"></script>
            <script src="../../Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
