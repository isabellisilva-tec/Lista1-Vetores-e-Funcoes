using System;
using Biblioteca;

/*11-Entrada A entrada consiste de uma única linha, contendo uma mensagem escrita na língua do P
eletrônica de Jacy e Kátia.
Saída Seu programa deve produzir uma única linha, contendo a mensagem decodificada.
Restrições A mensagem contém apenas letras maiúsculas e minúsculas e espaços em branco. A
mensagem tem entre 1 e 1000 caracteres. Não há dois espaços em branco consecutivos na mensagem.*/

class Exercicio11
{
    static String decodificar(String codificada)
    {
        char[] decodificada = new char[codificada.Length]; // estanciando o meu vetor 
    
        int j=0;
        for(int i=0; i<codificada.Length; i++)
        {
            if(codificada[i] != 'p')
            {
                decodificada[j] = codificada[i];
                j++;
            } //fim if

            else if(i !=0 && i != codificada.Length-1 && codificada[i+1] =='p' && codificada[i-1] =='p') 
            {
                 decodificada[j] = codificada[i];
                j++;
            }
        }//fim for

        return new String(decodificada);
    }
    static void Main()
    {
        String codificada;

        Console.Write("Entre com a frase codificada: ");
        codificada = Console.ReadLine();
       // OUTRA FORMA DE CHAMAR A FUNÇÃO -> resultado = decodificar(codificada);

        //chamar a função e apresentar decodificada
        Console.WriteLine("Palavra decodificada: "+ decodificar(codificada));
     
    }

}

