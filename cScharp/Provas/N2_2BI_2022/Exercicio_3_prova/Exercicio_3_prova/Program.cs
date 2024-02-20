using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomes;
            Int16 idade=0;
            int testeNome;
            
            for(Int32 cont = 0; cont < 100; cont++)
            {
                Console.Write($"Digite seu nome completo: ");
                nomes = Console.ReadLine();
                testeNome = nomes.IndexOf(" ");

                if (idade < 0 || idade > 80)
                {
                    Console.Write($"Digite sua idade: ");
                    idade = Convert.ToInt16(Console.ReadLine());
                }

            }
            
            Console.Write($"teste {nomes.Substring(0, testeNome)}");
            Console.ReadKey();
        }
    }
}
