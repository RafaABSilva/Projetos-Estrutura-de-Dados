using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Ordenacoes
/// </summary>
public class Ordenacoes {

    /// <summary>
    /// Ordenação por troca
    /// Troca por adjacência (vizinho)
    /// </summary>
    /// <param name="vetor"></param>
    /// <returns></returns>
    public static int[] BubbleSort(int[] vetor) {
        for (int i = vetor.Length - 1; i >= 0; i--) {
            for (int j = 0; j < i; j++) {
                if (vetor[j] > vetor[j + 1]) {
                    int troca = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = troca;
                }
            }
        }
        return vetor;
    }

    /// <summary>
    /// Troca
    /// Bi
    /// trás pra frente 
    /// frente pra trás
    /// </summary>
    /// <param name="vetor"></param>
    /// <returns></returns>
    public static int[] CookTail(int[] vetor) {
        bool troca = true;
        int inicio = 0;
        int fim = vetor.Length;

        while (troca == true) {
            // Reseta aflag troca para verificar se há alguma iteração
            // com a condião de troca
            troca = false;

            // Loop de baixo pra cima = bouble sort
            for (int i = inicio; i < fim - 1; ++i) {
                if (vetor[i] > vetor[i + 1]) {
                    int aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    troca = true;
                }// Fim do if de troca bubble
            }//fim do for bubble

            //se não houver  mudanças no primeiro for, sai fora!
            if (troca == false)
                break;

            // caso contário, setar a flag troca para false para continuar
            // o próximo passo... a próxima iteração
            troca = false;

            //move o ponto final para um anterior,
            // porque o item no final está no seu lugar
            fim = fim - 1; ;

            //de cima para baixo, fazendo a mesma comparação
            //do estágio anterior
            for (int i = fim - 1; i >= inicio; i--) {
                if (vetor[i] > vetor[i + 1]) {
                    int aux = vetor[i];
                    vetor[i] = vetor[i + 1];
                    vetor[i + 1] = aux;
                    troca = true;
                }
            }


            //aumentar o ponto de partida, porque o último estágio
            //teria o mesmo valor para seu devido lugar.
            //Não precisa compara algo que já foi comparado e setado
            //na sua posição
            inicio = inicio + 1;

        }// fim do while

        return vetor;
    }// fim do método cocktail
}