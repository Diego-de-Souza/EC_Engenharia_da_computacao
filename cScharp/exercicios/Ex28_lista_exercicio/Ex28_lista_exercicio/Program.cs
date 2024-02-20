using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex28_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            for(Int32 num = 1; num <=1000; num += 1)
            {
                if(num % 2 == 0)
                {
                    Console.WriteLine("{0} é ímpar!", num);
                }
                else
                {
                    Console.WriteLine("{0} é par!", num);
                }

                if (num % 100 == 0)
                {
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
