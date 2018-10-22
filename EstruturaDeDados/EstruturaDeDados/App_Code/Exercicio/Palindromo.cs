using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Palindromo
/// </summary>
public class Palindromo {

    private string palavra;

    public string Palavra {
        set { palavra = value; }
        get { return palavra; }
    }

    public string isPalindromo() {
        char[] arrChar = palavra.ToCharArray();

        Array.Reverse(arrChar);

        string palavraInvertida = new String(arrChar);

        if (palavra.Equals(palavraInvertida)) {
            return "É um Palíndromo! Palavra digitada: " + palavra;
        }

        return "NÃO é um Palíndromo! Palavra digitada: " + palavra + " | Resultado: " + palavraInvertida;

    }

}