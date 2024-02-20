using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_lista_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de váriaveis
            string nome, sobrenome, rua, n, bairro, cidade, estado, cep;

            //solicita os dados para o usuario
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.Write("Digite o nome da rua onde mora: ");
            rua = Console.ReadLine();

            Console.Write("Digite o numero da casa: ");
            n = Console.ReadLine();

            Console.Write("Digite o nome do Bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Digite o nome da cidade: ");
            cidade = Console.ReadLine();

            Console.Write("Digite o nome do estado: ");
            estado = Console.ReadLine();

            Console.Write("Digite o cep: ");
            cep = Console.ReadLine();

            //após a inserção dos dados é impresso na tela os dados
            Console.Write("\n\nSr.{0} {1} Residente a rua {2},{3},{4} - {5} - {6} - {7}", nome, sobrenome, rua, n, bairro, cidade, estado, cep);

            //comando para que a tela não seja fechada instantaneamente após a impressão dos dados
            Console.ReadKey();
        }
    }
}
