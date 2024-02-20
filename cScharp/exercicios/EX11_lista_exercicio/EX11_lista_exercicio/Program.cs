using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //poderiamos declarar a várivale antes, mas vamos declarar junto ao atribuimento
            //Solicita aue o usuario digite um numero
            Console.Write("Digite um número: ");
            Int16 num = Convert.ToInt16(Console.ReadLine());

            //laço condicional que diz se o numero é par ou impar
            if ((num % 2) == 0)
                Console.Write("O número é par");
            else
                Console.Write("O número é ímpar");


            Console.ReadKey();
        }
    }
}
