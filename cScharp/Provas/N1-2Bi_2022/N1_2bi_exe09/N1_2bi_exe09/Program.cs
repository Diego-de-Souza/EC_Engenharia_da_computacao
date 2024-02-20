using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 somaDosNumerosPares = 0, quantNumerosPares=0;
            for(Int32 num=100; num <= 200; num++)
            {
                if (num % 2 == 0)
                {
                    somaDosNumerosPares = somaDosNumerosPares + num;
                    quantNumerosPares++;
                }
            }
            //escreve na tela a soma dos números pares
            Console.Write("Soma dos números pares de 100 a 200 é {0} \nsão um total de {1} numeros pares", somaDosNumerosPares, quantNumerosPares);
            Console.ReadKey();
        }
    }
}
