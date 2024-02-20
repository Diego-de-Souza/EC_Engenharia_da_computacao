using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita ao usuario a inserção dos dados
            Console.Write("Digite um CEP XXXXX-XXX: ");
            string cep = Console.ReadLine().Trim();

            //laço condicional para validação do CEP
            if(cep.Length==9 && cep[5] == '-')
            {
                Console.Write("\nFormato do CEP correto!");
            }
            else
            {
                Console.Write("\nFormato do CEP incorreto!");
            }

            Console.ReadKey();
        }
    }
}
