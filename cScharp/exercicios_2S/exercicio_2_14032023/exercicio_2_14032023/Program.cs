using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2_14032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um vetor de objetos de classe
            ContaBancaria[] contaBanco = new ContaBancaria[3];
            string nome;
            int conta, valorSaque, valorDep;
            Random rnd = new Random();


            for (int i = 0; i < contaBanco.Length; i++)
            {
                nome = "cliente"+i;
                conta = 2025125+i;
                ContaBancaria proxConta = new ContaBancaria(nome, conta);
                contaBanco[i] = proxConta;
                
                valorDep = rnd.Next(1, 5000);
                contaBanco[i].depositar(valorDep);
                Console.WriteLine($"Depositado R${valorDep} ao cliente{i}"); 
            }
            Console.WriteLine("\n");
            for (int x = 0; x < contaBanco.Length; x++)
            {
                while (contaBanco[x].statusOperacao == true)
                {
                    valorSaque = rnd.Next(1, 500);
                    contaBanco[x].Sacar(valorSaque);
                    Console.WriteLine($"Saque cliente{x} de R${valorSaque} bem sucedido");
                    if (contaBanco[x].statusOperacao == false)
                    {
                        Console.WriteLine($"Não foi possivel fazer o saque de R${valorSaque}, Saldo indisponivel!");
                    }
                }
                
                
            }
            Console.WriteLine("\n");

            for (int resultado = 0; resultado < contaBanco.Length; resultado++)
            {
                Console.WriteLine($"Titular da conta: {contaBanco[(resultado)].nomeTitular}");
                Console.WriteLine($"Número da Conta: {contaBanco[(resultado)].numeroConta}");
                Console.WriteLine($"Saldo: {contaBanco[(resultado)].saldo}");
            }


            Console.ReadKey();
        }
    }
}
