using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //solicita o dado de entrada do usuario
            Console.Write("Digite um número: ");
            Int32 num = Convert.ToInt32(Console.ReadLine());
            //lógica do qualculo da fatorial
            Int32 calculoFatorial=1;
            for(Int32 i = 1;num >1; num--)
            {
                calculoFatorial = calculoFatorial * num;    
            }
            Console.Write("O calculo Fatorial do número digitado é: {0}",calculoFatorial);
            Console.ReadKey();
        }
    }
}
