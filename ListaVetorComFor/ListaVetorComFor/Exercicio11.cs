using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio11
    {
        public Exercicio11()
        {
            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNomes: ");

            for (int i = 0; i < nomes.Length; i++)
            {
                
                Console.Write(nomes[i] + ", " + nomes[3] + "e ");
            }
           
            
            
        }
    }
}
