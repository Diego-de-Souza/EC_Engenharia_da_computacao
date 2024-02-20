using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX23_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados ao usuario
            Console.Write("Digite sua altura(metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu peço(kg): ");
            double kilos = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua idade(anos): ");
            double idade = Convert.ToDouble((Console.ReadLine()));

            //laço condicional para impressão de resultado na tela

            if((altura>= 1.70 && altura<=1.85)&&(kilos>=48 && kilos<=60)&&(idade>=15 && idade <= 20))
            {
                Console.WriteLine("Candidato Aprovado!");
            }
            else
            {
                Console.WriteLine("Candidato Reprovado!");
            }

            Console.ReadKey();

            

        }
    }
}
