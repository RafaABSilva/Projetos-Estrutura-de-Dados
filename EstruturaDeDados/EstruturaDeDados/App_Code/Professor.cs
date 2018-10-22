using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Professor
/// </summary>
public class Professor {
    private int matricula;
    private Pessoa pessoa;

    public int Matricula {
        get { return matricula; }
        set { matricula = value; }
    }

    public global :: Pessoa Pessoa {
        get { return pessoa; }
        set { pessoa = value; }
    }
}
