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

                if (numero % 2 == 0)
                {
                    numeroPar[1] = numeroPar[1] + 1;
                }

                else 
                {
                    numeroImpar[1] = numeroImpar[1] + 1;
                }

                
                
            }

            Console.Clear();

            Console.WriteLine("Números cadastrados: ");

            for (int i = 0; i < numeroCadastrado.Length; i++)
            {
                
                Console.WriteLine("Vetor original: " +  numeroCadastrado[i] + ", ");
                Console.WriteLine("Numero par: " + numeroPar[1] + ", ");
                Console.WriteLine("Numero ímpar: " + numeroImpar[1] + ", ");
                
            }

            

            

        }
    }
}
