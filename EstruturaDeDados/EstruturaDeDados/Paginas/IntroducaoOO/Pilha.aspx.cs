using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_IntroducaoOO_Pilha : System.Web.UI.Page {

    Stack<string> pilha;

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Response.Write("Não é postback!");
            Listar();
        } else {
            Response.Write("É postback!");
        }
    }

    public void Qtd(Stack<string> pilha) {
        lblQtd.Text = pilha.Count().ToString();
    }

    protected void btnAdd_Click(object sender, EventArgs e) {
        Add(txtNomes.Text);
    }

    public void Add(string nome) {

        if (Session["PILHA"] == null) {
            pilha = new Stack<string>();
        } else {
            pilha = (Stack<string>)Session["PILHA"];
        }

        pilha.Push(nome);

        Session["PILHA"] = pilha;

        Listar();
    }

    public void Listar() {
        lblMostrar.Text = @"<ul>";

        if (Session["PILHA"] != null) {
            pilha = (Stack<string>)Session["PILHA"];
            foreach (string variavel in pilha) {
                lblMostrar.Text += "<li>" + variavel + "</li>";
            }

            Qtd(pilha);

        } else {
            lblMostrar.Text = "<li>Não há elementos na Fila</li>";
        }
        lblMostrar.Text += @"</ul>";
    }
    /// <summary>
    /// Mostra o primeiro e retira
    /// </summary>
    public void Retirar() {
        if (Session["PILHA"] != null) {
            pilha = (Stack<string>)Session["PILHA"];
            if (pilha.Count() != 0) {
                pilha.Pop();
                Session["PILHA"] = pilha;
                Listar();
            }
            if (pilha.Count() == 0) {
                lblMostrar.Text = "<ul><li>Não há elementos na Fila</li></ul>";
                lblQtd.Text = "";

            }

        } else {
            lblMostrar.Text = "<ul><li>Não há elementos na Fila</li></ul>";
            lblQtd.Text = "";
        }

    }

    /// <summary>
    /// Só mostra e não retira
    /// </summary>
    public void Topo() {

        if (Session["PILHA"] != null) {
            pilha = (Stack<string>)Session["PILHA"];
            lblMostrar.Text = "<ul><li>" + pilha.Peek() + "</li></ul>";
        }
    }


    protected void btnZerarFila_Click(object sender, EventArgs e) {
        Session["PILHA"] = null;
        Listar();
        lblQtd.Text = "";
    }

    protected void btnTopo_Click(object sender, EventArgs e) {
        Topo();
    }

    protected void btnVerFila_Click(object sender, EventArgs e) {
        Listar();
    }

    protected void btnRetirar_Click(object sender, EventArgs e) {
        Retirar();
    }
}


