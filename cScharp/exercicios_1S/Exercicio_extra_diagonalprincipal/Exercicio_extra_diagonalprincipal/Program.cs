using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_extra_diagonalprincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16[,] matriz = new Int16[4,4];
            Random rnd = new Random();
            Int64 soma = 0;
            
            //entrando com os dados
            for(int lin=0; lin < 4; lin++)
            {
                for(int col=0; col < 4; col++) {
                    //está fazendo um cast para Int16
                    matriz[lin, col] = (Int16)rnd.Next(1, 2);
                    Console.WriteLine($"Matriz[{lin}, {col}]: {matriz[lin, col]}");

                    //calcula a diagonal principal
                    if(lin == (col-1) || lin == )
                    {
                        soma += matriz[lin, col];
                    }
                }
            }
            Console.WriteLine($"{soma}");
            Console.ReadKey();
        }
    }
}
