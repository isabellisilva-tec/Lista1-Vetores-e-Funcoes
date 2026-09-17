using System;

/*4. Dado um vetor de n números reais, crie uma função que retorne o menor elemento do vetor, apresente o
vetor.*/
class Exercicio4
{
    static double menorElemento(double[] vetor)
        {
            double menor = vetor[0];
                for(int i=1; i<vetor.Length; i++)
                {
                    if (vetor[i] < menor)
                    {
                        menor = vetor[i];
                    }
        
                }
                return menor; 
        }

    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        double[] vetor = new double[N];

        for(int i = 0; i<vetor.Length; i++)
        {
            Console.Write($"vetor[{i}]: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i<vetor.Length; i++)
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |

        Console.WriteLine("|");

        double menor = menorElemento(vetor);
        Console.WriteLine($"Menor Elemento: "+menor);

    }
}