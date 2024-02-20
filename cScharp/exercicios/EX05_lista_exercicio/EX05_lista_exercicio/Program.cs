using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            double x, b, h, r, j;

            //solicita os dados para o usuario para poder efetuar o calculo
            Console.Write("Digite o valor de B: ");
            b=Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de H: ");
            h=Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de J: ");
            j=Convert.ToDouble(Console.ReadLine());

            //executa os calculos com os dados inseridos
            x = (Math.Pow(b, 3)) * h;
            r = x / j;

            //imprime os dados na tela
            Console.Write("\n\nConforme os dados inseridos executamos os seguintes calculos" +
                $" (B^3)*h e depois x/j e obtemos como resultado o valor: {r}");

            Console.ReadKey();
        }
    }
}
