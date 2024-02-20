using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicita os dados do usuário
            Console.Write("Digite seu nome: ");
            string nome=Console.ReadLine();

            Console.Write("Digite qual seu sexo (M/F): ");
            string sexo=Console.ReadLine().ToUpper(); //colocar o "toUpper()" faz com que a string fique
                                                      //em letra maiuscula, é um metodo de tratamento
                                                      //de string

            Console.Write("Digite seu salário: ");
            double salario= Convert.ToDouble(Console.ReadLine());

            //imprime na tela os dados 
            Console.WriteLine($"Ola Sr.(a) {nome}, seu salário é {salario}");

            //laço condicional para sexo
            if(sexo == "M")
            {
                Console.WriteLine("Masculino");
            }
            else
            {
                Console.WriteLine("Feminina");
            }

            //laço condicional para situação financeira
            if(salario <= 0)
            {
                Console.Write("Você está Fálido");
            }
            else if(salario >=1 && salario <= 15000)
            {
                Console.Write("Você é marajá");
            }
            else
            {
                Console.Write("Está muito bem de vida hein");
            }

            Console.ReadKey();

        }
    }
}
