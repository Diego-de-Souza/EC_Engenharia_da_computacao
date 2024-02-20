using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0411_random
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerando números randomicos

            //criar objeto para geração
            Random rnd = new Random();

            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("Gerado: " + rnd.Next(1,50));
            }
            Console.ReadKey();
        }
    }
}
