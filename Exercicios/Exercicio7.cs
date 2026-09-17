using System;
using BibliotecaFuncoes;

/*7. Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
se encontra no vetor. Apresente também todos elementos do vetor. A verificação deve ser realizada a partir
de uma função.*/
class Exercicio7
{
    
    static void Main()
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N]; 

        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite os numeros que serão colocados no vetor: ");
            int numero = int.Parse(Console.ReadLine());

            vetor[i] = numero;
        }

        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i<vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");

        Console.Write("Digite o numero que você quer procurar: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

         
       int quantidade = Vetor.encontrarValor(vetor, numeroProcurado);
       Console.WriteLine($"Quantidade de numeros encontrados: "+quantidade);
    }
}