using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[,] matriz = new Int32[1000, 1000];
            Int32 linha, coluna, matrizIdentidade=0;

            for(linha = 0; linha <1000; linha++)
            {
                for(coluna=0; coluna < 1000; coluna++)
                {
                    if(linha != coluna)
                    {
                        matriz[linha, coluna] = 0;
                    }
                    else
                    {
                        matriz[linha, coluna] = 1;
                    }
                }
            }

            for (linha = 0; linha < 1000; linha++)
            {
                
                for (coluna = 0; coluna < 1000; coluna++)
                {
                    if(linha == coluna)
                    {
                        matrizIdentidade++;
                    }
                    Console.Write($"{matriz[linha, coluna]}");
                }
                Console.Write("\n");
            }
            if (matrizIdentidade == 1000)
            {
                Console.WriteLine("É isso ai, essa é uma matriz identidade! ");
            }
           
            Console.ReadKey();
        }
    }
}
