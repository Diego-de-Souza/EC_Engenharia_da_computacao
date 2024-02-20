using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita ao usuario a inserção dos dados 
            Console.Write("Digite uma data DD/MM/AAAA: ");
            string dataCompleta = Console.ReadLine();

            //efetua o tratamento dos dados
            string diaC = dataCompleta.Substring(0, 2);
            string mesC = dataCompleta.Substring(3, 2);
            string anoC = dataCompleta.Substring(6, 4);

            //imprime na tela a data separada
            Console.Write("{0} \n{1} \n{2}",diaC,mesC,anoC);

            Console.ReadKey();
        }
    }
}
