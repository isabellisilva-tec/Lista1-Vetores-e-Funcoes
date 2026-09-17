using System;
using BibliotecaFuncoes;

/*5. Escreva um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
usuário digita um número e seu programa em C# deve acusar se o número digitado está no vetor ou não. Se
estiver, diga a posição que está. A verificação deve ser realizada a partir de uma função.*/
class Exercicio5
{

    static void Main(){

    Console.Write("Digite a quantidade de elementos do vetor: ");
    int numero = int.Parse(Console.ReadLine());

    int[] vetor = new int[numero]; //criando o meu vetor

    Random aleatorio = new Random();

    //Aqui é onde os numeros do meu vetor será sorteados aleatoriamente
    for(int i =0; i < numero; i++)
        {
            vetor[i] = aleatorio.Next(1, 100);
        }


        Console.Write("Digite o numero que você quer procurar:  ");
        int numeroBuscar = int.Parse(Console.ReadLine());

        int posicao = Vetor.verificarNumero(vetor, numeroBuscar);

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