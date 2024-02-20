using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numero;
            
            do
            {
                Console.Write("Digite a informação: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero >= 30 && numero <= 45);

            Console.ReadKey();
        }
    }
}
