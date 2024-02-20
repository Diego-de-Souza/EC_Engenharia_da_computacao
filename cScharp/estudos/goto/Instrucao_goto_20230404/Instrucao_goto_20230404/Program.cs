using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrucao_goto_20230404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara uma variavel
            int myInteger = 5;
            //inicia a instrução goto para pular para label.
            goto meuLabel;

                myInteger += 10;
            Console.WriteLine("Interessante, muito interessante este tipo de artificio");

            //lembrar de após o label colocar ":" ao invés de ";"
            //label para onde o programa vai ser direcionado após a instrucao goto
            meuLabel:

            //imprime na tela o resultado
            Console.WriteLine(myInteger);

            Console.ReadKey();
        }
    }
}
