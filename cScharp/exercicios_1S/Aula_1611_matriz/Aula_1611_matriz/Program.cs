using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1611_matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 linha, coluna;
            Int32[,] matriz = new Int32[5, 4];
            Int32[,,] precos = new Int32[5, 4, 3];
            Int32[] vetor = new Int32[4];


            for(linha=0;linha <5; linha++)
            {
                for(coluna=0;coluna< 4; coluna++)
                {
                    Console.Write($"Digite valor para ({linha}-{coluna}): ");
                    matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    //Console.Write($"({linha}-{coluna})\t");
                }
                Console.WriteLine("");
            }
            //para listar dados
            for (linha = 0; linha < 5; linha++)
            {
                for(coluna =0; coluna < 4; coluna++)
                {
                    Console.WriteLine($"{linha}-{coluna}: " +  
                        $"{matriz[linha,coluna]}");
                }
            }
            Console.ReadKey();
        }
    }
}
