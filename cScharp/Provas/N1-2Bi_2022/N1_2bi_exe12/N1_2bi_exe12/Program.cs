using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel de contagem de numeros divisores
            
            for(Int32 num=100;num <= 1000; num++)
            {
                Int32 contagemN = 0;
                for (Int32 i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        contagemN++;
                    }
                }
                if(contagemN == 2)
                {
                    Console.WriteLine(num);
                }                
            }
            Console.ReadKey();
        }
    }
}
