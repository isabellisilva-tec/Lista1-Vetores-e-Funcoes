using System;
using BibliotecaFuncoes;
/*3. Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
vetor.*/
class Exercicio3
{
    static void Main(string[] args)
    {
    Console.Write("Digite a quantidade de elementos do vetor: ");
    int N = int.Parse(Console.ReadLine());

     double[] vetor = new double[N]; //criando o meu vetor

      for(int i=0; i < vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: "); // mostra os vetores nas suas devidas posições
            vetor[i] = double.Parse(Console.ReadLine());
        } // fim do for


        //mostra os dados do meu vetor
        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i< vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");

        double maior = Vetor.maiorElemento(vetor);
        Console.WriteLine($"Maior Elemento: "+maior);

    }
}