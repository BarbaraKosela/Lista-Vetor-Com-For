using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            int[] idade = new int[7];

            for (int i = 0; i < idade.Length; i++)
            {
                Console.Write("Digite sua idade: ");
                idade[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.Write("Pessoas cadastradas: \n");

            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine("Idade: " + idade[i]);

            }
        }
    }
}
