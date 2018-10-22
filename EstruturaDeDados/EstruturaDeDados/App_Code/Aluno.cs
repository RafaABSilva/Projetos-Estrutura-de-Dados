using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Aluno
/// </summary>
public class Aluno {
    private string ra;
    private Pessoa pessoa;

    public string RA {
        get { return ra; }
        set { ra = value; }
    }

    public global :: Pessoa Pessoa {
        get { return pessoa; }
        set { pessoa = value; }
    }
}