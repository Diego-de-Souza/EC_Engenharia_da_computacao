using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            string nome;
            float n1, n2, result;

            //solicita nome e as notas do usuário
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a nota da N1: ");
            n1=float.Parse(Console.ReadLine());

            Console.Write("Digite a nota da N2: ");
            n2=float.Parse(Console.ReadLine());

            //executa o calculo da média
            //é necessário efetuar um cast neste exemplo, pois, o valor difgitado manualmente
            //no programa é considerado um double
            result= (float)(n1*0.4 + n2*0.6);

            //imprime o nome e resultado da media do aluno na tela
            Console.Write($"Sr. {nome} sua média é {result}");

            Console.ReadKey();

        }
    }
}
