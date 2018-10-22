using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_IntroducaoOO_Fila : System.Web.UI.Page {

    Queue<string> fila;

    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            Response.Write("Não é postback!");
            Listar();
        } else {
            Response.Write("É postback!");
        }
    }

    public void Qtd(Queue<string> fila) {
        lblQtd.Text = fila.Count().ToString();
    }

    protected void btnAdd_Click(object sender, EventArgs e) {
        Add(txtNomes.Text);
    }

    public void Add(string nome) {

        if (Session["FILA"] == null) {
            fila = new Queue<string>();
        } else {
            fila = (Queue<string>)Session["FILA"];
        }

        fila.Enqueue(nome);

        Session["FILA"] = fila;

        Listar();
    }

    public void Listar() {
        lblMostrar.Text = @"<ul>";

        if (Session["FILA"] != null) {
            fila = (Queue<string>)Session["FILA"];
            foreach (string variavel in fila) {
                lblMostrar.Text += "<li>" + variavel + "</li>";
            }

            Qtd(fila);

        } else {
            lblMostrar.Text = "<li>Não há elementos na Fila</li>";
        }
        lblMostrar.Text += @"</ul>";
    }
    /// <summary>
    /// Mostra o primeiro e retira
    /// </summary>
    public void Retirar() {
        if (Session["FILA"] != null) {
            fila = (Queue<string>)Session["FILA"];
            if (fila.Count() != 0) {
                fila.Dequeue();
                Session["FILA"] = fila;
                Listar();
            } 
            if(fila.Count() == 0) {
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

        if (Session["FILA"] != null) {
            fila = (Queue<string>)Session["FILA"];
            lblMostrar.Text = "<ul><li>" + fila.Peek() + "</li></ul>";
        }
    }


    protected void btnZerarFila_Click(object sender, EventArgs e) {
        Session["FILA"] = null;
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