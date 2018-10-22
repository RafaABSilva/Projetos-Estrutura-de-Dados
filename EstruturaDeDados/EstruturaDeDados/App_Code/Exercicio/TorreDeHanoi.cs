using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de TorreDeHanoi
/// </summary>
public class TorreDeHanoi {

    private string saida;

    public TorreDeHanoi() {
        //
        // TODO: Adicionar lógica do construtor aqui
        //
    }

    private void movetorre(int n, char orig, char dest, char aux) {
        if (n == 1) {
            saida += "<br />Mover disco 1 da torre "+orig+" para a torre "+ dest;
            return;
        }
        movetorre(n - 1, orig, aux, dest);
        saida += "<br />Mover disco "+n+" da torre " + orig + " para a torre " + dest;
        movetorre(n - 1, aux, dest, orig);
    }

    public string main() {
        int discos=3;
        movetorre(discos, 'A', 'C', 'B');
        return saida;
    }
}