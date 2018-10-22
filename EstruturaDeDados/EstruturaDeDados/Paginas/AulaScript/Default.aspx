<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Paginas_AulaScript_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Content/font-awesome.min.css" rel="stylesheet" />
    <style>
        .vermelho{
            color:red;
        }
        .verde{
            color:green;
        }
        .azul{
            color:blue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="row">
                <div class="col-md-12">
                    <p id="lblifo" cor="v" class="vermelho">Informação sobre a página</p>
                    <asp:TextBox runat="server" ID="txtTexto" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-12">
                    <br />
                    <br />
                    <a class="btn btn-primary" id="btnOK">Ver</a>
                    <br />
                    <br />
                    <a id="btnCurtir" curtir="l"><i class="fa fa-thumbs-up fa-5x icone"></i></a>
                </div>

            </div>

        </div>
    </form>
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../../Scripts/jsScript.js"></script>


</body>
</html>
