using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio10
    {
        public Exercicio10()
        {
            string[] nomes = new string[10];
            int quantidadeNomesS = 0, quantidadeNomesA = 0, quantidadeSilva = 0, silva = 0;
            string nome = "";
           


            for (int i = 0; i < nomes.Length; i++)
			{
			    Console.Write("Nome: ");
                nomes[i] = Console.ReadLine().ToLower();
                nome = nomes[i].Substring(0);
                
			}

            Console.Clear();

            Console.WriteLine("Nomes cadastrados: ");
            Console.WriteLine(" ");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Nome: " + nomes[i]);
                

            }

            string maiorNome = "", menorNome = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length < menorNome.Length)
                {
                    menorNome = nomes[i];
                }
            }

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length > maiorNome.Length)
                {
                    maiorNome = nomes[i];
                }
            }

            

            for (int i = 0; i < nomes.Length; i++)
            {
                nome = nomes[i].Substring(0, 1);
                if (nome == "s")
                {
                    quantidadeNomesS = quantidadeNomesS + 1;
                }
            }

            
            
            
            for (int i = 0; i < nomes.Length; i++)
            
            {
                nome = nomes[i].Substring(0, 1);
               
                if (nome == "a")
                {
                    quantidadeNomesA = quantidadeNomesA + 1;
                }

            }

            
            
           




            Console.WriteLine("\nMaior nome: " + maiorNome);
            Console.WriteLine("Menor nome: " + menorNome);
            Console.WriteLine("Quantidade de pessoas com a inicial S: " + quantidadeNomesS);
            Console.WriteLine("Quantidade de pessoas com a inicial A: " + quantidadeNomesA);






        }
    }
}
