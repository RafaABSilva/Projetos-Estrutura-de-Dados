using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Estudo_para_prova_pilhaComStatic : System.Web.UI.Page {

    static Stack<string> pilha = new Stack<string>();

    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void btnadd_Click(object sender, EventArgs e) {
        pilha.Push(txt.Text);

        ltr.Text = "";

        ltr.Text += "<ul>";
        foreach(string variavel in pilha) {
            ltr.Text += "<li>" + variavel + "</li>";
        }
        ltr.Text += "</ul>";

    }

    protected void btnrem_Click(object sender, EventArgs e) {
        pilha.Pop();

        ltr.Text = "";

        ltr.Text += "<ul>";
        foreach (string variavel in pilha) {
            ltr.Text += "<li>" + variavel + "</li>";
        }
        ltr.Text += "</ul>";

    }

    protected void btnexplodir_Click(object sender, EventArgs e) {
        pilha.Clear();
        ltr.Text = "";
    }




}