using System;

class Ex1
{

    //FUNÇÃO 
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

        Console.WriteLine("Digite a quantidade de elementos do vetor: ");
        N = int.Parse(Console.ReadLine());
    
        int[] vetor = new int[N]; // esse é o meu vetor; ou seja, estou criando o vetor
       

       //Lê os dados do meu vetor (estrutura padrão)
        for(int i=0; i < vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: "); // mostra os vetores nas suas devidas posições
            vetor[i] = int.Parse(Console.ReadLine());
        } // fim do for

       
        //mostra todos os dados que foram recebidos do vetor
        /*Console.WriteLine("Dados do vetor: ");
        for(int i=0; i< vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");*/

        //passa o vetor para a função(somaVetor) e recebe a soma(que é o meu resultado)
        resultado = somaVetor(vetor);
        Console.WriteLine("A soma total é de: "+resultado);
    }
}

