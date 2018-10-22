using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Estrutura
/// </summary>
public class Estrutura {

    private string informacao = null;
    private Estrutura proximo = null;

    public string Informacao {
        set { informacao = value; }
        get { return informacao; }
    }

    public Estrutura Proximo {
        set { proximo = value; }
        get { return proximo; }
    }

    public Estrutura(string informacao, Estrutura proximo) {

        this.informacao = informacao;
        this.proximo = proximo;

    }

    public Estrutura(string informacao) {

        this.informacao = informacao;
        this.proximo = null;

    }
}