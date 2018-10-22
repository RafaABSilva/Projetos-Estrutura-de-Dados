using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_IntroducaoOO_Exercicios_Ordernar : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
        oi();
    }

    private void oi() {
        int[] valor = { 1, 5, 6 , 7 };

        saida.Text = "Array Original: ";
        for (int u = 0; u < valor.Length; u++) {
            if(u != valor.Length - 1) {
                saida.Text += valor[u] + " - ";
            } else {
                saida.Text += valor[u];
            }
        }


        for (int i=valor.Length-1; i>=0; i--) {
            for(int j = 0; j < valor.Length; j++) {
                if (j + 1 < valor.Length) {
                    if (valor[j] < valor[j + 1]) {
                        int troca = valor[j];
                        valor[j] = valor[j + 1];
                        valor[j + 1] = troca;
                    }
                }
        }
            saida2.Text = "Array Ordenado: ";
            for (int u = 0; u < valor.Length; u++) {
                if (u != valor.Length - 1) {
                    saida2.Text += valor[u] + " - ";
                } else {
                    saida2.Text += valor[u];
                };
            }
            
    }

    }
}