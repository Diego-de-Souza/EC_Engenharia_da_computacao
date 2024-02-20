using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis como temos 2 variáveis vou declarar aqui em cima e por didática
            double result, baseN, expoente;

            //Solicita ao usuário que digite dois numeros
            Console.Write("Digite um número para base da exponenciação: ");
            baseN = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um número para expoente: ");
            expoente = Convert.ToDouble(Console.ReadLine());

            //executa o calculo
            result = Math.Pow(baseN, expoente);

            //escreve o resultado na tela
            Console.Write($"o resultado da potenciação é {result}");

            Console.ReadKey();
        }
    }
}
