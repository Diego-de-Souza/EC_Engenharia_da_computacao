using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX32_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados do usuario
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Int16 cont = 0;

            //logica condicional para contar as letras
            for( Int16 num=0; num < frase.Length; num++)
            {
                if(frase[num] != ' ')
                {
                    cont++;
                }
            }

            Console.WriteLine("A frase tem {0} letras.", cont);

            Console.ReadKey();
        }
    }
}
