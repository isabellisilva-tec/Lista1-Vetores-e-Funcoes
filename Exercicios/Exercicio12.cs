using System;
using Biblioteca;
/*12-A entrada contém uma única linha, contendo cinco números Ni (1 ≤ i ≤ 5), todos com uma casa decimal, 
indicando as notas recebidas pela agremiação em um dos quesitos. Armazene em um vetor e 
passa como parâmetro para a função.
Saída : Sua função deve retornar um único número com exatamente uma casa decimal, 
a nota final da escola de samba no quesito considerado.*/
class Exercicio12{
    
        public static double obterMaiorNota(double[] notas)
        {
            double maiorNota = notas[0];
            for(int i=1; i<notas.Length; i++)
            {
                if (notas[i] > maiorNota)
                {
                    maiorNota = notas[i];
                }
    
            }
            return maiorNota;
        }

        public static double obterMenorNota(double[] notas)
        {
            double menorNota = notas[0];
            for(int i=1; i<notas.Length; i++)
            {
                if (notas[i]<menorNota)
                {
                    menorNota = notas[i];
                }
                
            }
            return menorNota;
        }

        public static double somarNotas(double[] notas)
        {
            double soma = 0;
            for(int i= 0; i<notas.Length;i++)
            {
                soma += notas[i];
            }
            
            return soma;
        }

        public static double calcularNotaFinal(double[] notas)
        {
            return somarNotas(notas) - obterMaiorNota(notas) - obterMenorNota(notas);
        }

    static void Main()
    {
      Console.WriteLine("Exercicio 12 - Notas Carnaval");
        double[] notas = new double[5];
        double resultado;
        Console.WriteLine("Digite as 5 notas ");
        for(int i = 0; i < notas.Length; i++) {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        resultado = calcularNotaFinal(notas);
        Console.WriteLine($"Nota Final: {resultado:F1}");


    }
}