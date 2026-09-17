using System;

using Biblioteca;

/*9. Leia um vetor DNA de caracteres para receber as letras A, T, C e G que representam as bases do DNA. Este
vetor será responsável por representar uma fita de um gene de até 50 bases. Gere o vetor complementar ao
vetor DNA e o apresente (Lembrando as bases complementares A=T C=G).*/
 
class Exercicio9
{ 
    static char[] gerarComplementar(char[] dna)
    {
        char[] complementar = new char[dna.Length];

        for(int i = 0; i < dna.Length; i++)
        {
            switch(dna[i])
            {
                case 'A':
                complementar[i] = 'T';
                break;
                
                case 'T':
                complementar[i] = 'A';
                break;

                case 'C':
                complementar[i] = 'G';
                break;

                 case 'G':
                complementar[i] = 'C';
                break;

            }
         }
         return complementar;
        }
    static void Main()
    {
        
       Console.Write("Digite a sequencia de DNA: ");
       string  sequencia = Console.ReadLine();

       char[] dna = sequencia.ToCharArray();

      char[] complementar = gerarComplementar(dna);

       Console.Write("DNA complementar: ");

       for(int i = 0; i < complementar.Length; i++)
        {
            Console.Write(complementar[i]);
        }
        
    }
    
}