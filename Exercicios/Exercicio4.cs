using System;
using BibliotecaFuncoes;

/*4. Dado um vetor de n números reais, crie uma função que retorne o menor elemento do vetor, apresente o
vetor.*/
class Exercicio4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        double[] vetor = new double[N];

        for(int i = 0; i<vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i<vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");

        double menor = Vetor.menorElemento(vetor);
        Console.WriteLine($"Menor Elemento: "+menor);

    }
}