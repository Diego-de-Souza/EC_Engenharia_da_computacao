using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprime na tela o alfabeto de A a Z
            Console.WriteLine("Abaixo o alfabeto de 'A' á 'Z' e seus correspondentes em ASCII;");
            for(char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine("{0} : {1}",i,(int)i );
            }
            Console.ReadKey();

        }
    }
}
