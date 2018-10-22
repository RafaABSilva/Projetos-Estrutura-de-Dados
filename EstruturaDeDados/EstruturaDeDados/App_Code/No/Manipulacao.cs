using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Manipulacao
/// </summary>
public class Manipulacao {

    private Estrutura cabeca, calda;

    public void add(string informacao) {

        if (cabeca == null) {
            cabeca = new Estrutura(informacao);
        } else {
            cabeca.Proximo = new Estrutura(informacao);
        }

    }
}