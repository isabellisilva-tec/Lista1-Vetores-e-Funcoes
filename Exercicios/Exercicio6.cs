using System;
using System.Collections.Specialized;
using BibliotecaFuncoes;

/*6. Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
mesmo índice, colocando o resultado em um terceiro vetor. A multiplicação deve ser feito por meio de uma
função. Retorne o vetor resultante e apresente.*/
class Exercicio6
{
    static void Main()
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[N];
        int[] vetor2 = new int[N];


        for(int i = 0; i < vetor1.Length; i++)
        {
            Console.Write("Digite um número para o vetor 1: ");
            int numero = int.Parse(Console.ReadLine());

            vetor1[i] = numero;
        }


        Console.WriteLine(" ");
        for(int i = 0; i < vetor2.Length; i++)
        {
            Console.Write("Digite um número para o vetor 2: ");
            int numero = int.Parse(Console.ReadLine());

            vetor2[i] = numero;
        }

        int[] resultadoVetor = Vetor.multiplicarElementos(vetor1, vetor2);

        for(int i=0; i < resultadoVetor.Length; i++)
        {
            Console.Write(resultadoVetor[i]+ " ");
        }
    
    }
}
    
