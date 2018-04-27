using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio05
    {
        public Exercicio05()
        {

            Console.WriteLine("Quantidade de jogos que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());

            string[] jogos = new string[quantidadedeRegistros];
            int[] unidades = new int[quantidadedeRegistros];

            for (int i = 0; i < jogos.Length; i++)
            {
                Console.Write("\nNome do jogo: ");
                jogos[i] = Console.ReadLine();
                Console.Write("\nUnidades em estoque: ");
                unidades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\n\nJogos cadastrados para estoque: ");
            for (int i = 0; i < jogos.Length; i++)
            {
                Console.WriteLine("\nNome do jogo: " + jogos[i] + "\nUnidades: " + unidades[i] + "\n");
            }

        }
    }
}
