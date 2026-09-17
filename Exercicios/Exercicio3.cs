using System;

/*3. Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
vetor.*/
class Exercicio3
{
         static double maiorElemento(double[] vetor)
        {
            double maior = vetor[0];

                for(int i=1; i<vetor.Length; i++)
                {
                    if (vetor[i] > maior)
                    {
                        maior = vetor[i];
                    }
        
                }
                return maior; 
        }
    static void Main(string[] args)
    {
    Console.Write("Digite a quantidade de elementos do vetor: ");
    int N = int.Parse(Console.ReadLine());

     double[] vetor = new double[N]; //criando o meu vetor

        // le os dados do meu vetor
        for(int i=0; i<vetor.Length; i++)
        {
        Console.Write($"vetor[{i}]: ");
        vetor[i] = double.Parse(Console.ReadLine()); //todos os valores armazenados separados por |
        }
       

        Console.WriteLine("Dados do vetor: ");
        for(int i=0; i<vetor.Length; i++){
        Console.Write("|"+vetor[i]); //todos os valores armazenados separados por |
        }

        Console.WriteLine("|");

        double maior = maiorElemento(vetor);

        Console.WriteLine($"Maior Elemento: "+maior);

    }
}