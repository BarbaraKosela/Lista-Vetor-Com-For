using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] numeros = new int[10];

            

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número aleatório: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Números cadastrados: \n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Número: " + numeros[i]);
                
            }

            

            double soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            double media = soma / numeros.Length;
            

            Console.WriteLine("Soma dos números: " + soma);
            Console.WriteLine("Média dos números: " + media);
        }
    }
}
