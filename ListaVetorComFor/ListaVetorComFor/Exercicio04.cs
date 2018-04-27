using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetorComFor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            string[] tamanho = new string[4];
            int camisetasPP = 0, camisetasP = 0, camisetasM = 0, camisetasG = 0, camisetasGG = 0, camisetasXG = 0, camisetasXGG = 0;

            for (int i = 0; i < tamanho.Length; i++)
            {
                Console.Write("Digite o tamanho: ");
                tamanho[i] = Console.ReadLine().ToLower();

            }

            Console.Clear();

            Console.WriteLine("Tamanho de todas as camisetas cadastradas: ");

            for (int i = 0; i < tamanho.Length; i++)
			{
			 
                Console.WriteLine("Tamanho: " + tamanho[i]);

                if (tamanho[i] == "pp")
                {
                    camisetasPP = camisetasPP + 1;
                }

                else if (tamanho[i] == "p")
                {
                    camisetasP = camisetasP + 1;
                }

                else if (tamanho[i] == "m")
                {
                    camisetasM = camisetasM + 1;
                }

                else if (tamanho[i] == "g")
                {
                    camisetasG = camisetasG + 1;
                }

                else if (tamanho[i] == "gg")
                {
                    camisetasGG = camisetasGG + 1;
                }

                else if (tamanho[i] == "xg")
                {
                    camisetasXG = camisetasXG + 1;
                }

                else if (tamanho[i] == "xgg")
                {
                    camisetasXGG = camisetasXGG + 1;
                }
               
			}

            

            Console.WriteLine("\nQuantidade de camisetas com o tamanho PP: " + camisetasPP);
            Console.WriteLine("Quantidade de camisetas com o tamanho P: " + camisetasP);
            Console.WriteLine("Quantidade de camisetas com o tamanho M: " + camisetasM);
            Console.WriteLine("Quantidade de camisetas com o tamanho G: " + camisetasG);
            Console.WriteLine("Quantidade de camisetas com o tamanho GG: " + camisetasGG);
            Console.WriteLine("Quantidade de camisetas com o tamanho XG: " + camisetasXG);
            Console.WriteLine("Quantidade de camisetas com o tamanho XGG: " + camisetasXGG);
            
            
                

               
                   
            }


          
        }
    }

