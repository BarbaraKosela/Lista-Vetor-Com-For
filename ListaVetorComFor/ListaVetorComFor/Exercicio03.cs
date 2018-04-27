using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.Write("Digite a quantidade de registros que deseja cadastrar: ");
            int quantidadedeRegistros = Convert.ToInt32(Console.ReadLine());

            double[] preco = new double[quantidadedeRegistros];

            for (int i = 0; i < preco.Length; i++)
            {
                Console.Write("\nDigite o preço: ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Preços cadastrados: \n");

            for (int i = 0; i < preco.Length; i++)
            {
                Console.WriteLine("Preço: " + preco[i]);
            }

            double somaPreco = 0;
            for (int i = 0; i < preco.Length; i++)
            {
                somaPreco = preco[i] + somaPreco;
            }

            Console.WriteLine("\nO total de preços é de: " + somaPreco);
        }

    }
}
