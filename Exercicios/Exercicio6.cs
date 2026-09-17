using System;
using Biblioteca;

/*6. Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
mesmo índice, colocando o resultado em um terceiro vetor. A multiplicação deve ser feito por meio de uma
função. Retorne o vetor resultante e apresente.*/
class Exercicio6
{
    static int[] multiplicarElementos(int[] vetor1, int[] vetor2)
    {
        int[] resultadoVetor = new int[vetor1.Length];

         for(int i = 0; i < vetor1.Length; i++)
        {
            resultadoVetor[i] = vetor1[i] * vetor2[i];
        }
        return resultadoVetor;
    }
    static void Main()
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[N];
        int[] vetor2 = new int[N];

        Console.WriteLine("Vetor 1 ");
        BibliotecaVetor.lerVetor(vetor1);

        Console.WriteLine(" ");  
        Console.WriteLine("Vetor 2");
        BibliotecaVetor.lerVetor(vetor2);

      int[] resultadoVetor = multiplicarElementos(vetor1, vetor2);

       
        Console.WriteLine("Vetor resultante:");
        for(int i=0; i < resultadoVetor.Length; i++)
        {
            Console.Write(resultadoVetor[i]+ " ");
        }
    
    }
}
    
