using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX27_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //laço de lógica condicional
            Int32 contador, soma, inteiro;

            soma = 0;
            contador = 1;
            do
            {
                
                soma = soma + (contador % 2);
                contador = contador + 1;
                
            } while (soma < 10);

            Console.WriteLine(contador);

            Console.ReadKey();
        }
    }
}
