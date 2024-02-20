using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //obs. as declarações serão junto com a atribuição

            //Solicitando os dados para o usuario
            Console.Write("Digite a distancia em o movel A e o B: ");
            double dab= Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velovidade do movel A: ");
            double va=Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade do movel B: ");
            double vb=Convert.ToDouble(Console.ReadLine());

            //laço consicional que dependendo da velocidade de va e vb executa o calculo
            if (va <= vb)
            {
                Console.Write("Os móveis nunca se encontrarão!");
            }
            else
            {
                //executando as formulas 
                double t = dab / (va - vb);
                double local = va * t;

                //imprime na tela o resultado
                Console.Write($"Os móveis se encontrarão em {local}km depois de {t} tempo");
            }

            Console.ReadKey();
        }
    }
}
