using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            string[] nomes = new string[25];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
            }
        }
    }
}
