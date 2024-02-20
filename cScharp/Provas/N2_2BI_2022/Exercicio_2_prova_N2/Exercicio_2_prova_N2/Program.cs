using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_prova_N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 numInicial, numFinal, divFour=0, divFive=0;

            Console.Write($"Digite um número inicial: ");
            numInicial=Convert.ToInt32(Console.ReadLine());
            Console.Write($"Digite um número final: ");
            numFinal = Convert.ToInt32(Console.ReadLine());

            if(numInicial > numFinal)
            {
                Console.WriteLine($"ERROR: Desculpe dados inconsistentes, o número inicial não pode ser maior que o final!");
            }
            else
            {
                for(Int32 num= numInicial;num <= numFinal; num++) {
                    if (num % 4 == 0)
                    {
                        divFour++;
                    }else if (num % 5 == 0)
                    {
                        divFive++;
                    }

                }
                Console.WriteLine($"A quantidade de número divisiveis por 4 é : {divFour}");
                Console.WriteLine($"A quantidade de número divisiveis por 5 é : {divFive}");
            }
            

            Console.ReadKey();
        }
    }
}
