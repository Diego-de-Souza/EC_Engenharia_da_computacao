using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_matriz_extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das váriaveis
            Int32[,] matriz = new Int32[4, 3];
            Int32[] novoVetor = new Int32[4];
            Int16 linha, coluna,soma=0;

            //laço condicional, solicita os dados da matriz e analisa quantos são pares
            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
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
                    soma += Convert.ToInt16(matriz[linha,coluna]);
                }
                novoVetor[linha]=soma;
                Console.WriteLine($"A somatoria da linha {linha} é {novoVetor[linha]} ");
                
                soma = 0;
            }

            Console.ReadKey();
        }
    }
}
