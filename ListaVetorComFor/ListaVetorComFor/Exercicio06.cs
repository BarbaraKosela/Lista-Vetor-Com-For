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
            int numerosPares = 0, numerosPositivos = 0, numerosImpares = 0, numerosNegativos = 0, numerosNeutros = 0;
            

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o número: ");
                Random gerarAleatorio = new Random();
                numeros[i] = gerarAleatorio.Next(0, 52);
            }

            Console.Clear();
            Console.WriteLine("Números cadastrados: \n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Número: " + numeros[i]);

                if (numeros[i] % 2 == 0)
                {
                    numerosPares = numerosPares + 1;
                }

            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    numerosPositivos = numerosPositivos + 1;
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] %2 != 0)
                {
                    numerosImpares = numerosImpares + 1;
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    numerosNegativos = numerosNegativos + 1;
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    numerosNeutros = numerosNeutros + 1;
                }
            }

            

            double soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            double media = soma / numeros.Length;
            

            Console.WriteLine("Soma dos números: " + soma);
            Console.WriteLine("Média dos números: " + media);
            Console.WriteLine("Quantidade de números pares: " + numerosPares);
            Console.WriteLine("Quantidade de números positivos: " + numerosPositivos);
            Console.WriteLine("Quantidade de números impares: " + numerosImpares);
            Console.WriteLine("Quantidade de números negativos: " + numerosNegativos);
            Console.WriteLine("Quantidade de números neutros: " + numerosNeutros);
        }
    }
}
