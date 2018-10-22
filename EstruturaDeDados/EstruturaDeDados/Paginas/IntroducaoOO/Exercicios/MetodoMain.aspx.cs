using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_IntroducaoOO_Exercicios_Palindromo : System.Web.UI.Page {

    static Stack<string> pilha;
    //Stack<string> pilhaProf;

    protected void Page_Load(object sender, EventArgs e) {

    }

    public void imprimir() {

        saida.Text += @"<ul>";
        foreach (string variavel in pilha) {
            saida.Text += "<li>" + variavel + "</li>";
        }
        saida.Text += @"</ul>";

    }

    //public void Listar(string p) {
    //    string invertida = "";
    //    foreach (char letra in pilha) {
    //        invertida += letra;
    //    }
    //    if (p == invertida) {
    //        saida.Text = "É um Palíndromo!";
    //    } else {
    //        saida.Text = "Não é um Palíndromo!";
    //    }
    //}


    protected void btn_Click(object sender, EventArgs e) {
        Palindromo entrada = new Palindromo();

        //char[] palavra = textEntrada.Text.ToCharArray();
        //pilhaProf = new Stack<char>(palavra);
        //Listar(textEntrada.Text);

        pilha = new Stack<string>();

        entrada.Palavra = textEntrada.Text;

        pilha.Push(entrada.isPalindromo());


        imprimir();
    }
}

