using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados do usuario e declara as variaveis
            Console.Write("Digiete seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sexo ('M' ou 'F'): ");
            char sexo = Console.ReadKey().KeyChar;

            //coloca a primeira letra do nome em outra váriavel
            var inicial = nome.ToUpper()[0];

            //laço condicional
            if(inicial=='A' || inicial=='E' || inicial=='I' ||inicial=='O' || inicial == 'U')
            {
                Console.WriteLine("\n\n Olá {0}, seu nome começa com uma vogal.", nome);
            }
            else
            {
                Console.WriteLine("\n\n Olá {0}, seu nome começa com uma consoante.", nome);
            }

            if(sexo=='F' || sexo == 'f') { 
                Console.WriteLine("Sexo feminino");
            }else if(sexo=='M' || sexo == 'm')
            {
                Console.WriteLine("Sexo Masculino");
            }
            else
            {
                Console.WriteLine("sexo Indefinido");
            }

            Console.ReadKey();


        }
    }
}
