using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprime na tela um poema com o pulo de linha
            Console.WriteLine("Batatinha quando nasce" +
                "\nse esparrama pelo chão. \nMenininha quando dorme" +
                "\npõe a mão no coração"); //o sinal "+" somente é usado para deixar o texto no editor mais
                                            //visivel dentro da tela, para não precisar rolar para direita

            //neste caso o que faz o texto pular para outra linha é a inserção do "\n"

            Console.ReadKey();
        }
    }
}
