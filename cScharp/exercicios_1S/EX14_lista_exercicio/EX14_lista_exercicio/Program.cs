using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            double n1, n2, n3, media, nRecuperacao;

            //solicita as notas para o usuario
            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            //calculo da media
            media = ((n1 + n2) + n3) / 3;

            //imprime a media
            Console.WriteLine("\n{0}",media);

            //laço condicional que mostra sua situação
            if(media <= 4)
            {
                Console.Write("\nReprovado direto!");
            }
            else if(media >= 7)
            {
                Console.Write("\nAprovado");
            }
            else
            {
                Console.WriteLine("Recuperação!");
                //Solicita que o usuario insira a nora da recuperação
                Console.Write("\nDigite a Nota da recuperação: ");
                nRecuperacao = Convert.ToDouble(Console.ReadLine());
                if(nRecuperacao > 5)
                {
                    Console.Write("\nAprovado");
                }
                else
                {
                    Console.Write("Reprovado");
                }
            }

            Console.ReadKey();
        }
    }
}
