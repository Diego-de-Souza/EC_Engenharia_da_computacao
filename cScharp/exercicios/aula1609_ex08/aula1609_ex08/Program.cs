using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1609_ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Int16 idade;

            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            idade = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"Olá {nome}, sua idade é {idade}");
            
            if (idade == 0)
            {
                Console.WriteLine("Você é bebê");
            } else if (idade <= 12){
                Console.WriteLine("Você é criança");
            } else if (idade <= 18){
                Console.WriteLine("Você é adolescente");
            } else if (idade <= 60){
                Console.WriteLine("Você é Adulto");
            } else if (idade <120){
                Console.WriteLine("Você é idoso");
            }else {
                Console.WriteLine("Você é Múmia");
            }
                        
            Console.ReadKey();
        }
    }
}
