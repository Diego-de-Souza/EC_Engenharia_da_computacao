using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados para o usuario
            Console.Write("Digite um numero para fatoração: ");
            Int32 num = Convert.ToInt32(Console.ReadLine());

            Int32 count=1;

            //laço lógico que efetua a fatoração
            do
            {
                count = count * num;
                num -= 1;
            }while(num > 1);
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
