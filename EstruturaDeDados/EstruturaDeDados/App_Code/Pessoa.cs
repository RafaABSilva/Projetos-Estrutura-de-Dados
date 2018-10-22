using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Pessoa
/// </summary>
public class Pessoa {
    private int codigo;
    private string nome;

    public int Codigo {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
}