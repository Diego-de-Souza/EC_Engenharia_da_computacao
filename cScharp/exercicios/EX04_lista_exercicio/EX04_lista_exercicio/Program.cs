using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            double r, b, c, d;

            //solicita que o usuario insira os dados solicitados
            Console.Write("Digite um valor para B: ");
            b=double.Parse(Console.ReadLine()); //uma das forma de converter os dados inseridos para double

            Console.Write("Digite um valor para C: ");
            c=Convert.ToDouble(Console.ReadLine()); //outra forma de converter os dados inseridos para double

            Console.Write("Digite um valor para D: ");
            d=Convert.ToDouble(Console.ReadLine());

            //execução dos calculos
            //poderiamos colocar "b*b" para fazer a exponenciação, mas resolvi usar a
            //biblioteca math com o metodo "POW" para fazer a exponenciação para fins didaticos
            r = (Math.Pow(b,2)) - (c * d);

            //imprime os dados na tela, colocaremo o "$" antes das aspas duplas e a variavel dentro das aspas
            //que é outra forma de poder inserir os dados na frase
            Console.Write($"A expressão B^2-(C*D) conforme os dados inseridos é: {r}");

            Console.ReadKey();

        }
    }
}
