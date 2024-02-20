using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0411_vetoresErandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] numeros = new int[100];
            //randomicos
            Random rnd = new Random();

            //vamos simular a digitação dos 100numeros
            for(int i=0; i < 100; i++)
            {
                //gera números inteiros entre 1 e 100
                numeros[i] = rnd.Next(1, 101);
                Console.WriteLine($"Digite um Numero-{i}: {numeros[i]}");
            }
            Console.ReadKey();
        }
    }
}
