using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX31_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados para o usuario
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Digite um letra: ");
            char letra = Console.ReadLine()[0];
            /*
            Console.Write("digite 1: ");
            //usar o parse int pode dar problema caso o usuario insira mais de um letra
            char teste = char.Parse(Console.ReadLine());
            */

            Int16 cont = 0;
            
            //laço condicional para buscar quantas vezes tem a letra dentro da frase
            for(Int32 num=1; num <= frase.Length; num++)
            {
                
                if (frase[num-1].ToString().ToUpper() == letra.ToString().ToUpper())
                {
                    cont++;
                }
                
            }
            Console.Write("A letra {0} apareceu {1} vezes", letra, cont);
            
            Console.ReadKey();
        }
    }
}
