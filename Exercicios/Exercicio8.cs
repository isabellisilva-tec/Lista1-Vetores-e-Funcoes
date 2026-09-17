using System;
using Biblioteca;

/*8. Leia um vetor de caracteres. Utilize a função Length para obter a quantidade de elementos do vetor de
caracteres. Escreva o vetor lido em ordem inversa. A inversão deve ser realizada a partir de uma função.*/
class Exercicio8
{
    static char[] ordemInversa(char[] palavra)
    {
        int j = 0;
        char[] caracteres = new char[palavra.Length];
         
        for(int i = palavra.Length - 1; i >= 0; i --)
        {
            caracteres[j] = palavra[i];
            j++;
        }
         return caracteres;
    }
    static void Main(string[] args){

    Console.Write("Digite uma palavra: ");
    String palavra = (Console.ReadLine());

    char[] caracteres = new char[palavra.Length];

    //ESSE FOR PREENCHE O MEU VETOR
    for(int i=0; i < palavra.Length; i++)
        {
            caracteres[i] = palavra[i];
        }

    char[] resultado = ordemInversa(caracteres);

    //ESSE FOR MOSTRA NA TELA O VETOR QUE A FUNÇAÕ DEVOLVEU
    Console.Write("Ordem inversa: ");
    for(int i=0; i < resultado.Length; i++)
        {
            Console.Write(resultado[i]);
        }
    
    }


    
}