using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX29_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados do usuario
            Console.Write("Digite uma palavra: ");
            string palavraDig = Console.ReadLine();

            /* outro exemplo
             * for(Int32 num=0;num < palavraDig.Length; num++)
            {
                Console.WriteLine(palavraDig[num]);
            }
             */
            /*exemplo do programa invertendo a ordem de impressão
             * for (Int32 num=(palavraDig.Length); num >=1; num--)
            {
                Console.WriteLine(palavraDig[num-1]);
            }
             */

            for (Int32 num=1; num <=palavraDig.Length; num++)
            {
                Console.WriteLine(palavraDig[num-1]);
            }

            Console.ReadKey();
        }
    }
}
