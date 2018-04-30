using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio09
    {
        public Exercicio09()
        {
            double[] notas = new double[4];
            string[] nome = new string[1];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Matéria: ");
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i < notas.Length; i++)
            {

                
                Console.WriteLine("\nNota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                

            }

            Console.Clear();

            
            Console.WriteLine("Notas cadastradas: ");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("\nNota: " + notas[i]);
            }

            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma = notas[i] + soma;
            }
            double media = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                media = soma / 4;
            }

            Console.WriteLine("\nSua média é de: " + media);
        }
    }
}
