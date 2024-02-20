using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_da_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] matriz = new Int32[5];
            Random rnd = new Random();
            Int32 soma = 0;
            double media = 0;

            Console.WriteLine($"Digite um numero: ");
            for (Int32 cont = 1;cont <= 4; cont++)
            {
                
                matriz[cont] = rnd.Next(1, 50);
                soma += matriz[cont];
                media = Convert.ToDouble(soma / cont);
                Console.WriteLine($"A média é: {media:F}");
                Console.WriteLine($"ultimo número inserido : {matriz[cont]}");
            }

            Console.ReadKey();
        }
    }
}
