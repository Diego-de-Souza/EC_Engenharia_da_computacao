using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operador_ternario_20230404
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Demonstração do operador ternário. (este comentário aparece em view > task List)

            ///Este programa tem como principio demonstrar a utilização do operador ternário
            ///em todas suas formas de uso, ou a maior possivel

            int myInteger = 5;
            //exemplo 1
            string resultadoDaString = (myInteger < 10) ? "Menor que 10" : "Maior que 10";
            string resultadoDaString2 = (myInteger > 10) ? "Menor que 10" : "Maior que 10";
            //imprime na tela o resultado dos operadores ternarios
            Console.WriteLine("No 1° operador ternario o resultado é: {0} " +
                "\nNo 2° operador ternario o resultado é: {1}",resultadoDaString,resultadoDaString2);

            //operador ternario com calculo
            string resultadoSoma = (20 + 20 == 10) ? "Soma correta" : "Soma incorreta";
            string resultadoSoma2 = (20 + 20 == 40) ? "Soma correta" : "Soma incorreta";
            Console.WriteLine(resultadoSoma);
            Console.WriteLine(resultadoSoma2);

            Int16 meuAnoDeNasc = 1988;
            //operador ternario imprimindo numeros
            Int32 minhaIdade = (meuAnoDeNasc == 1988) ? 1988 : 2023;
            Console.WriteLine(minhaIdade);

            Console.ReadKey();
        }
    }
}
