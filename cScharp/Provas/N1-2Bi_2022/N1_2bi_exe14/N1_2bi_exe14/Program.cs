using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita ao usuário que insira o número maximo para fibonacci
            Console.Write("Digite o número inteiro máximo para contagem de Fibonacci: ");
            Int32 seqFibo = Convert.ToInt32(Console.ReadLine());
            //criação da variável de controle do laço
            Int32 fibo = 1, a=0;
            //criação da lógica de contagem de Fibonacci
            while(fibo <= seqFibo)
            {
                Console.Write(a + " " + fibo + " ");
                a += fibo;
                fibo += a;
            }
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
