using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            string nome;
            double salario, despesaS, despesaL, despesaA, saldo;

            //solicita os dados para o usuario
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o valor de seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de gastos com saúde: ");
            despesaS = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de gastos com lazer: ");
            despesaL = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de gastos com alimentação: ");
            despesaA = Convert.ToDouble(Console.ReadLine());

            //executa calculos para ver saldo
            saldo = salario - (despesaS + despesaL + despesaA);

            //laço condicional para descrever a situação do usuario
            if (saldo < 0)
                Console.Write($"\nÉ {nome}, Gaste menos.");
            else if (saldo > 0 && saldo <= 3000)
                Console.Write($"\nÉ {nome}, Melhor fazer uma poupança.");
            else if (saldo > 3000 && saldo <= 5000)
                Console.Write($"\nÉ {nome}, Sobrou bastante hein!");
            else
                Console.Write($"\nÉ {nome}, Parabéns corintiano!!");

            Console.ReadKey();
        }
    }
}
