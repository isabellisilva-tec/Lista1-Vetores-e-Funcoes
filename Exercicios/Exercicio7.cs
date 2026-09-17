using System;
using Biblioteca;

/*7. Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
se encontra no vetor. Apresente também todos elementos do vetor. A verificação deve ser realizada a partir
de uma função.*/
class Exercicio7
{
    static int encontrarValor(int[] vetor, int numeroProcurado)
    {
        int quantidade = 0;

         for(int i = 0; i < vetor.Length; i++)
        {
           if(vetor[i] == numeroProcurado)
            {
                quantidade++;
            }
        }
      return quantidade;
    }
    static void Main()
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N]; 

        BibliotecaVetor.lerVetor(vetor);
        BibliotecaVetor.mostrarVetor(vetor);


        Console.Write("Digite o numero que você quer procurar: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

         
       int quantidade = encontrarValor(vetor, numeroProcurado);
       Console.WriteLine($"Quantidade de numeros encontrados: "+quantidade);
    }
}