using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Estudo_para_prova_filaComStatic : System.Web.UI.Page {

    static Queue<string> fila = new Queue<string>();

    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnadd_Click(object sender, EventArgs e) {
        fila.Enqueue(txt.Text);

        ltr.Text = "";

        ltr.Text += @"<ul>";
        foreach(string variavel in fila) {
            ltr.Text += "<li>" + variavel + "</li>"; 
        }
        ltr.Text += @"</ul>";


    }

    protected void btnrem_Click(object sender, EventArgs e) {
        fila.Dequeue();

        ltr.Text = "";

        ltr.Text += @"<ul>";
        foreach (string variavel in fila) {
            ltr.Text += "<li>" + variavel + "</li>";
        }
        ltr.Text += @"</ul>";
    }

    protected void btnexplodir_Click(object sender, EventArgs e) {
        fila.Clear();
        ltr.Text = "";
    }
}