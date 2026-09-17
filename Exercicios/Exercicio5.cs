using System;
using Biblioteca;

/*5. Escreva um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
usuário digita um número e seu programa em C# deve acusar se o número digitado está no vetor ou não. Se
estiver, diga a posição que está. A verificação deve ser realizada a partir de uma função.*/
class Exercicio5
{
     static int verificarNumero(int[] vetor, int numeroBuscar)
    {
         for(int i = 0; i < vetor.Length; i++)
        {
           if(vetor[i] == numeroBuscar)
            {
                return i;
            }
        }
      return -1;
    }
    static void Main(){

    Console.Write("Digite a quantidade de elementos do vetor: ");
    int numero = int.Parse(Console.ReadLine());

    int[] vetor = new int[numero]; //criando o meu vetor

    BibliotecaVetor.gerarVetor(vetor);
    BibliotecaVetor.mostrarVetor(vetor);

        Console.WriteLine("Digite o numero que você quer procurar:  ");
        int numeroBuscar = int.Parse(Console.ReadLine());

        int posicao = verificarNumero(vetor, numeroBuscar);

        if(posicao != -1)
            {
                Console.WriteLine("O número está na posição: " + posicao);
            }
            else
            {
                Console.WriteLine("O numero não está no vetor ");
            }



    }

}