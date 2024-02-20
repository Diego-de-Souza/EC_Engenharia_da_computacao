using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados para o usuario
            Console.Write("Digite um número qualquer: ");
            Int32 multiplicador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segue abaixo a tabuada do {0}", multiplicador);

            //laço condicional para calculo da tabuada
            for(Int32 tab=1; tab <=10; tab++)
            {
                Int32 tabuada = multiplicador * tab;
                Console.WriteLine("{0} x {1} = {2}",multiplicador,tab,tabuada);
            }

            Console.ReadKey();
        }
    }
}
