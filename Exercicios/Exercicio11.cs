using System;
using BibliotecaFuncoes;

/*11-Entrada A entrada consiste de uma única linha, contendo uma mensagem escrita na língua do P
eletrônica de Jacy e Kátia.
Saída Seu programa deve produzir uma única linha, contendo a mensagem decodificada.
Restrições A mensagem contém apenas letras maiúsculas e minúsculas e espaços em branco. A
mensagem tem entre 1 e 1000 caracteres. Não há dois espaços em branco consecutivos na mensagem.*/

class Exercicio11
{
    static void Main()
    {
        String codificada;
        Console.Write("Entre com a frase codificada: ");
        codificada = Console.ReadLine();
       // OUTRA FORMA DE CHAMAR A FUNÇÃO -> resultado = decodificar(codificada);

        //chamar a função e apresentar decodificada
        Console.WriteLine("Palavra decodificada: "+ Vetor.decodificar(codificada));
     
    }

}

