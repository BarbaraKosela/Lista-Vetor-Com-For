using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio08
    {
        public Exercicio08()
        {
            Console.WriteLine("Digite a quantidade de números que deseja cadastrar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            

            int[] numeroCadastrado = new int[numero];
            int[] numeroImpar = new int[numero];
            int[] numeroPar = new int[numero];

            
            

            for (int i = 0; i < numeroCadastrado.Length; i++)
            {
                Console.Write("\nNúmero: ");
                numeroCadastrado[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("\nVetor original: ");
            for (int i = 0; i < numeroCadastrado.Length; i++)
            {
                Console.WriteLine(" " + numeroCadastrado[i]);
            }

            Console.WriteLine("\nVetor par: ");
            for (int i = 0; i < numeroCadastrado.Length; i++)
            {
                if (numeroCadastrado[i] % 2 == 0)
                {
                    Console.WriteLine(" " + numeroCadastrado[i]);
                }
            }

            Console.WriteLine("\nVetor ímpar: ");
            for (int i = 0; i < numeroCadastrado.Length; i++)
            {
                if (numeroCadastrado[i] % 2 != 0)
                {
                    Console.WriteLine(" " + numeroCadastrado[i]);
                }
            }
            


           

            

            

        }
    }
}
