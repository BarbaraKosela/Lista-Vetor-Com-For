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


            string[] caracteres = new string[20];
            int quantidadeVogais = 0, quantidadeConsoantes = 0, quantidadeEspeciais = 0;
            

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine("Digite o caractere: ");
                caracteres[i] = Console.ReadLine();
                Console.WriteLine(" ");
            }

            
            for (int i = 0; i < caracteres.Length; i++)
            {
                if ((caracteres[i] == "a")||(caracteres[i] == "e")||(caracteres[i] == "i")||(caracteres[i] == "o")||(caracteres[i] == "u"))
                {
                    quantidadeVogais = quantidadeVogais + 1;
                    Console.WriteLine("Vogais: " + caracteres[i]);
                    
                }

                else if ((caracteres[i] == "b")||(caracteres[i] == "c")||(caracteres[i] == "d")||(caracteres[i] == "f")||(caracteres[i] == "g")||(caracteres[i] == "h")||(caracteres[i] == "j")||(caracteres[i] == "k")
                    ||(caracteres[i] == "l")||(caracteres[i] == "m")||(caracteres[i] == "n")||(caracteres[i] == "o")||(caracteres[i] == "p")||(caracteres[i] == "q")||(caracteres[i] == "r")||(caracteres[i] == "s")
                    ||(caracteres[i] == "t")||(caracteres[i] == "v")||(caracteres[i] == "w")||(caracteres[i] == "x")||(caracteres[i] == "y")||(caracteres[i] == "z"))
                {
                    quantidadeConsoantes = quantidadeConsoantes + 1;
                    Console.WriteLine("Consoantes: " + caracteres[i]);

                    
                }

                else
                {
                    quantidadeEspeciais = quantidadeEspeciais + 1;
                    Console.WriteLine("Caracteres especiais: " + caracteres[i]);
                    

                }
                
                
            }


            Console.WriteLine("\n\nQuantidade de consoantes: " + quantidadeConsoantes);
            Console.WriteLine("Quantidade de vogais: " + quantidadeVogais);
            Console.WriteLine("Quantidade de caracteres especiais: " + quantidadeEspeciais);
            
            
            
        }
    }
}

