using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_IntroducaoOO_Ordenacoes_Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        int[] vetor = { 4, 1, 3, 2, 5, 6, 7 };

        foreach(int a in vetor) {
            lblDesordenado.Text += a + "-";
        }

        lblDesordenado.Text = lblDesordenado.Text.Substring(0, lblDesordenado.Text.Length - 1);

        vetor = Ordenacoes.CookTail(vetor);
        foreach (int a in vetor) {
            lblOrdenado.Text += a + "-";
        }

        lblOrdenado.Text = lblOrdenado.Text.Substring(0, lblOrdenado.Text.Length - 1);
    }
}