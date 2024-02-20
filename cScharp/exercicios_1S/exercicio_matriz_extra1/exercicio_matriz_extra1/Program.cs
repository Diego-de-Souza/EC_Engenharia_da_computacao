using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_matriz_extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das váriaveis
            Int32[,] matriz = new int[4, 3];
            Int16 linha, coluna, numeroPar = 0;

            //laço condicional, solicita os dados da matriz e analisa quantos são pares
            for(linha=0;linha < 4; linha++)
            {
                for(coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Digite um número para matriz posição ({linha}-{coluna}): ");
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            //imprime a quantidade
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    if (matriz[linha, coluna] % 2 == 0)
                    {
                        numeroPar++;
                    }
                    else
                    {

                    }
                    
                }
                Console.WriteLine($"Tem {numeroPar} números pares na linha ({linha}-{coluna})");
                numeroPar = 0;
            }

            Console.ReadKey();
        }
    }
}
