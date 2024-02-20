using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bI_EXE01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração da váriavel que controla o laço
            char saiLaco = 'N';
            //seleciona os dados para o usuário
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            while (saiLaco == 'N')
            {
                double num2 = Double.Parse(Console.ReadLine());
                if (num2 != 0)
                {
                    saiLaco = 'S';
                    //efetua o calculo
                    double resul = num1 / num2;
                    Console.Write($" o resultado da divisão de {num1} por {num2} é {resul} ");
                }
                else
                {

                }
            }
            Console.ReadKey();

        }
    }
}
