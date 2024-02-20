using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            Int16 dia;
            
            //solicitando um numero para o usuario para responder em um dia da semana
            Console.Write("Digite um número de 1 a 7 para saber qual dia da semana: ");
            dia=Convert.ToInt16(Console.ReadLine());
           
            //laço condicional que responde um dia da semana dependendo do número
            //inserido pelo usuário
            if (dia == 1)
            {
                Console.WriteLine("\nDomingo");
            }
            else if(dia == 2)
            {
                Console.WriteLine("\nSegunda-Feira");
            }
            else if (dia == 3)
            {
                Console.WriteLine("\nTerça-Feira");
            }
            else if (dia == 4)
            {
                Console.WriteLine("\nQuarta-Feira");
            }
            else if (dia == 5)
            {
                Console.WriteLine("\nQuinta-Feira");
            }
            else if (dia == 6)
            {
                Console.WriteLine("\nSexta-Feira");
            }
            else if (dia == 7)
            {
                Console.WriteLine("\nSábado");
            }
            else
            {
                Console.WriteLine("\nO número digitado não corresponde a nenhum dia da semana!");
            }

            
            /*caso tenha a curiosidade de conhecer outra forma de fazer este exercicio segue abaixo
            não se esqueça de declarar a váriavel como byte, para funcionar melhor neste caso

            //laço condicional CASE
            //inicie com a palavra switch seguido da variável dentro dos parenteses
            switch (teste)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break ;
                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("O número digitado não corresponde a nenhum dia da semana!");
                    break;
            }*/

            Console.ReadKey();
            
            
        }
    }
}
