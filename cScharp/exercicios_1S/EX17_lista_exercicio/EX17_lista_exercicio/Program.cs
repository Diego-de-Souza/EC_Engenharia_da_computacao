using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita ao usauario os dados
            Console.Write("Digite seu nome Completo: ");
            string nomeFull = Console.ReadLine();

            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            Int32 idade = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o valor de seu salário: ");
            double salario = double.Parse(Console.ReadLine());

            //Impressão dos dados
            Console.WriteLine($"\n\nSua idade é {idade}");

            //identifica o caracter de espaço no nome digitado para pegar o primeiro nome
            int espacoBranco = nomeFull.IndexOf(" ");
            //Imprime o primeiro nome Digitado
            Console.WriteLine("Seu primeiro nome é {0}", nomeFull.Substring(0, espacoBranco));
            //Imprime as 3 ultimas letras do nome
            Console.WriteLine("As 3 ultimas letras do seu nome é '{0}'", nomeFull.Substring(nomeFull.Length -3));

            //Calculo de desconto de 11%  do INSS
            double descINSS = salario * 0.11;
            //Imprimindo na tela o salário já com desconto
            Console.WriteLine("VOcê teve R${0:F} de desconto, referente a 11% do INSS, seu salário liquido é de R${1:F}", descINSS, (salario - descINSS));

            //Imprimi o CPF sem hifen e sem ponto caso seja deigitado com eles
            Console.WriteLine("Seu CPF = {0}",cpf.Replace("-","").Replace(".",""));


            Console.ReadKey();
        }
    }
}
