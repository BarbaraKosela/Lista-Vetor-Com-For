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


            string[] caracteres = new string[5];
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
                }

                else if ((caracteres[i] == "b")||(caracteres[i] == "c")||(caracteres[i] == "d")||(caracteres[i] == "f")||(caracteres[i] == "g")||(caracteres[i] == "h")||(caracteres[i] == "j")||(caracteres[i] == "k")
                    ||(caracteres[i] == "l")||(caracteres[i] == "m")||(caracteres[i] == "n")||(caracteres[i] == "o")||(caracteres[i] == "p")||(caracteres[i] == "q")||(caracteres[i] == "r")||(caracteres[i] == "s")
                    ||(caracteres[i] == "t")||(caracteres[i] == "v")||(caracteres[i] == "w")||(caracteres[i] == "x")||(caracteres[i] == "y")||(caracteres[i] == "z"))
                {
                    quantidadeConsoantes = quantidadeConsoantes + 1;
                }

                else
                {
                    quantidadeEspeciais = quantidadeEspeciais + 1;
                }
                
                
            }


            Console.WriteLine("\nQuantidade de consoantes: " + quantidadeConsoantes);
            Console.WriteLine("\nQuantidade de vogais: " + quantidadeVogais);
            Console.WriteLine("\nQuantidade de caracteres especiais: " + quantidadeEspeciais);
            
            

            for (int i = 0; i < caracteres.Length; i++)
            {
                if ((caracteres[i] == "b") || (caracteres[i] == "c") || (caracteres[i] == "d") || (caracteres[i] == "f") || (caracteres[i] == "g") || (caracteres[i] == "h") || (caracteres[i] == "j") || (caracteres[i] == "k")
                    || (caracteres[i] == "l") || (caracteres[i] == "m") || (caracteres[i] == "n") || (caracteres[i] == "o") || (caracteres[i] == "p") || (caracteres[i] == "q") || (caracteres[i] == "r") || (caracteres[i] == "s")
                    || (caracteres[i] == "t") || (caracteres[i] == "v") || (caracteres[i] == "w") || (caracteres[i] == "x") || (caracteres[i] == "y") || (caracteres[i] == "z"))
                {
                    Console.WriteLine("\nAs consoantes: ");
                    Console.WriteLine(" " + caracteres[i]);
                    
                }

                
                
                else if ((caracteres[i] == "a") || (caracteres[i] == "e") || (caracteres[i] == "i") || (caracteres[i] == "o") || (caracteres[i] == "u"))
                   

                {
                        Console.WriteLine("\nAs vogais: ");
                        Console.WriteLine(" " + caracteres[i]);
                        
                    
                }

                else
                {
                    Console.WriteLine("\nOs caracteres especiais: ");
                    Console.WriteLine(" " + caracteres[i]);
                }
                
            }


            

        }
    }
}

