<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .jumbotron{
            padding: 0.4rem 2rem;
        }
        .card{
            text-align: center;
            height: 35vh;
            
        }
        .ajuste{
            margin-top:4vh;
        }
        .btn{
            width:10vw;
            margin:auto;
        }
        .form-control{
            width:90%;
            margin:auto;
        }
        .col-12{
            text-align: center;
            margin-bottom:2vh;
        }
        .card-title{
            margin-top:2vh;
        }
    </style>
</head>
<body class="jumbotron">
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="col-12">
                    <h1>Exercício de Estrutura de Dados</h1>
                    <h3>Rafael A. B . Silva</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="card">
                        <h5 class="card-title">Fatorial</h5>
                        <label></label>
                        <asp:TextBox ID="txtFat" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnFat" CssClass="btn" runat="server" Text="Calcular" OnClick="btnFat_Click" />
                        <asp:Literal ID="ltrFat" runat="server"></asp:Literal>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="card">
                        <h5 class="card-title">Sequência de Fibonacci</h5>
                        <asp:TextBox ID="txtFibo" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnFibo" CssClass="btn" runat="server" Text="Calcular" OnClick="btnFibo_Click" />
                        <asp:Literal ID="ltrFibo" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="card ajuste">
                        <h5 class="card-title">Máximo Divisor Comum</h5>
                        <asp:TextBox ID="txtMDC" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnMDC" CssClass="btn" runat="server" Text="Calcular" OnClick="btnMDC_Click" />
                        <asp:Literal ID="ltrMDC" runat="server"></asp:Literal>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="card ajuste">
                        <h5 class="card-title">Decimal para Binário</h5>
                        <asp:TextBox ID="txtDB" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:Button ID="btnDB" CssClass="btn" runat="server" Text="Calcular" OnClick="btnDB_Click" />
                        <asp:Literal ID="ltrDB" runat="server"></asp:Literal>
                    </div>
                </div>
            </div>

        </div>
    </form>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
