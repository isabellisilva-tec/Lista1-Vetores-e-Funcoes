using System;
using Biblioteca;

/*10. Tentando descobrir se um dado era viciado, um dono de cassino honesto o lançou N vezes. Dados os n
resultados dos lançamentos que devem ser armazenados em um vetor, crie uma função para determinar o
número de ocorrências de cada face. Retorne o vetor de ocorrencias resultante.*/
class Exercicio10
{
       static int[] numeroOcorrencias(int[] vetor)
    {
        
        int[] ocorrencias = new int[6];

        for(int i = 0; i < vetor.Length; i++)
        {
           int face = vetor[i];
           face = face - 1;

           ocorrencias[face]++;
        }
        return ocorrencias;
    }
      static void Main()
    {
        Console.Write("Digite a quantidade de lançamentos do dado: ");
        int quant = int.Parse(Console.ReadLine());

        int[] vetor = new int[quant]; 

        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite o valor do dado: ");
            int numero = int.Parse(Console.ReadLine());

            vetor[i] = numero;
        }

       int[] resultado = numeroOcorrencias(vetor);

        for(int i = 0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i] + " ");
            
        }


    }
}