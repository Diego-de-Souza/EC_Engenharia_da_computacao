using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            string nome;
            Int16 idade;

            //solicitando os dados ao usuário
            Console.Write("Digite seu nome: ");
            nome=Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            //laço condicional para impressão na tela do resultado
            if(idade == 0)
            {
                Console.Write($"Olá { nome}!Sua idade é { idade} você é bebê");
            }
            else if(idade >=0 && idade <= 12)
            {
                Console.Write($"Olá {nome}! Sua idade é {idade} você é criança");
            }
            else if(idade >12 && idade <= 18) 
            {
                Console.Write($"Olá {nome}! Sua idade é {idade} você é adolescente");            
            }
            else if(idade > 18 && idade <= 60)
            {
                Console.Write($"Olá {nome}! Sua idade é {idade} você é adulto");
            }
            else if(idade >60 && idade <= 120)
            {
                Console.Write($"Olá {nome}! Sua idade é {idade} você é idoso");
            }
            else
            {
                Console.Write("Essa não é uma idade válida! Digite uma idade válida.");
            }

            Console.ReadKey();
        }
    }
}
