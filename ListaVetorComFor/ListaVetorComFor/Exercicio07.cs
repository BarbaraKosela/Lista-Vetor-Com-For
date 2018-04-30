using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio07
    {
        public Exercicio07()
        {


            string caracteres;
            int i, cv;
            char[] vogais = { 'a', 'i', 'u', 'e', 'o' };
            int total = 0;
            
            Console.Write("Digite o caracter: ");
            caracteres = Console.ReadLine();

            for (i = 0; i <= caracteres.Length - 1; i++)
            {
                for (cv = 0; cv <= 4; cv++)
                {
                
                    if (Convert.ToChar(caracteres.Substring(i, 1)) == vogais[cv])

                    {
                        total++;
                    }
                }


                Console.Write("\nTotal: " + total);
                
            }



             }


        }
    }

