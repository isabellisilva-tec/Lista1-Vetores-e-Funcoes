using System;
using Biblioteca;
class Exercicio1
{
     static int somaVetor(int [] N) 
    {
        int soma = 0;

         for(int i=0; i < N.Length; i++)
        {
            soma = soma + N[i];
        }
        return soma;
    }

    static void Main()
    {
        int N, resultado;

        Console.Write("Digite a quantidade de elementos do vetor: ");
        N = int.Parse(Console.ReadLine());
    
        int[] vetor = new int[N]; // esse é o meu vetor; ou seja, estou criando o vetor
       
       BibliotecaVetor.lerVetor(vetor);

        resultado = somaVetor(vetor);
       
        Console.WriteLine("A soma total é de: "+resultado);


    }

}

