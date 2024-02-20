using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07102022_laçoFOR
{
    class Program
    {
        static void Main(string[] args)
        {   
            //laço condicional FOR, se inicia com a atribuição de um,a valor a uma variável
            //
            for(int cont=1; cont <=10; cont++)
            {
                Console.WriteLine($"Numero: {cont}");
            }

            Console.ReadKey();
        }
    }
}
