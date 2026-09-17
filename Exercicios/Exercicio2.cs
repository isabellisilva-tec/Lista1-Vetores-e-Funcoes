using System;
using Biblioteca;
/*2. Escreva um programa que leia ou gere um vetor de N elementos inteiros. 
A seguir, crie uma função que receba esse vetor e conte quantos valores impares 
existem no vetor. Retorne a quantidade de impares.*/

class Exercicio2
{
      static int quantidadeImpares(int[] vetor)
        {
            int quantidade = 0;

            for(int i = 0; i<vetor.Length; i++)
            {
                if(vetor[i] % 2 != 0)
                {
                    quantidade++;
                }
            }
            return quantidade;
        }

    static void Main()
    {
        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        BibliotecaVetor.lerVetor(vetor);
        BibliotecaVetor.mostrarVetor(vetor);
        
        Console.WriteLine("|");

        int quantidade = quantidadeImpares(vetor);

        Console.WriteLine("Quantidade de impares: " +quantidade);
    }
    
}
