using System;
using BibliotecaFuncoes;
/*12-A entrada contém uma única linha, contendo cinco números Ni (1 ≤ i ≤ 5), todos com uma casa decimal, 
indicando as notas recebidas pela agremiação em um dos quesitos. Armazene em um vetor e 
passa como parâmetro para a função.
Saída : Sua função deve retornar um único número com exatamente uma casa decimal, 
a nota final da escola de samba no quesito considerado.*/
class Exercicio12{

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

        resultado = Vetor.calcularNotaFinal(notas);
        Console.WriteLine($"Nota Final: {resultado:F1}");


    }
}