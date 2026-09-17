using System;

namespace BibliotecaFuncoes
{
      class Vetor{

    //FUNÇÃO 
    public static int somaVetor(int [] N) 
    {
        int soma = 0;

         for(int i=0; i < N.Length; i++)
        {
            soma = soma + N[i];
        }
        return soma;
        
    }
    public static char[] gerarComplementar(char[] dna)
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


     //FUNÇÃO MAIOR ELEMENTO
        public static double maiorElemento(double[] vetor)
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

    //FUNÇÃO MENOR ELEMENTO
        public static double menorElemento(double[] vetor)
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

            public static int quantidadeImpares(int[] vetor)
        {
            int quantidade = 0;

            for(int i = 0; i<vetor.Length; i++)
            {
                if(vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                    quantidade++;
                }
            }
            return quantidade;
        }


         public static String decodificar(String codificada)
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

     public static char[] ordemInversa(char[] palavra)
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

    
    public static int verificarNumero(int[] vetor, int numeroBuscar)
    {
         for(int i = 0; i < vetor.Length; i++)
        {
           if(vetor[i] == numeroBuscar)
            {
                return i;
            }
        }
      return -1;
    }

    public static int encontrarValor(int[] vetor, int numeroProcurado)
    {
        int quantidade = 0;

         for(int i = 0; i < vetor.Length; i++)
        {
           if(vetor[i] == numeroProcurado)
            {
                quantidade++;
            }
        }
      return quantidade;
    }

    
    public static int[] multiplicarElementos(int[] vetor1, int[] vetor2)
    {
        int[] resultadoVetor = new int[vetor1.Length];

         for(int i = 0; i < vetor1.Length; i++)
        {
            resultadoVetor[i] = vetor1[i] * vetor2[i];
        }
        return resultadoVetor;
    }

    
    public static int[] numeroOcorrencias(int[] vetor)
    {
        
        int[] ocorrencias = new int[6];

        for(int i = 0; i < vetor.Length; i++)
        {
           int face = vetor[i];
           face = face - 1;

           ocorrencias[face]++;
        }
        return ocorrencias;
    }


    }
}