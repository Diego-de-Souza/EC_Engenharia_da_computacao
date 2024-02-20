using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX33_lista_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados do usuario
            Console.Write("Digite uma frase para ve-la ao contrário: ");
            string frase = Console.ReadLine();

            char[] arrChar = frase.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            Console.Write(invertida);

            Console.ReadKey();


        }
    }
}
