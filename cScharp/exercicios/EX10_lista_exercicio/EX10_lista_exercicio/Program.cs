using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //como é simples a chamada de dados a declaração está junto com a atribuição.
            Console.Write("Digite um ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            //executa os calculos
            if (ano % 4 == 0)
            {
                Console.WriteLine("Este ano é bissexto!");
            }
            else
            {
                Console.WriteLine("Este ano NÃO é bissexto!");
            }

            Console.ReadLine();
        }
    }
}
