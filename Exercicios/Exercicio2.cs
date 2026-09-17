using System;
using BibliotecaFuncoes;
/*2. Escreva um programa que leia ou gere um vetor de N elementos inteiros. 
A seguir, crie uma função que receba esse vetor e conte quantos valores impares 
existem no vetor. Retorne a quantidade de impares.*/

class Exercicio2
{
   
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        for(int i = 0; i<vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i<vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");

        int quantidade = Vetor.quantidadeImpares(vetor);
        Console.WriteLine($"Quantidade de impares: "+quantidade);
    }
    
}
