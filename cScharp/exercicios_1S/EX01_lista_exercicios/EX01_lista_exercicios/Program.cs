using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_lista_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O programa solicita nome, endereço e telefone ao usuário e imprime na tela as informações

            //declaração de variáveis
            string nome, endereço, telefone;

            //Solicita os dados do usuário
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu endereço: ");
            endereço = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            telefone = Console.ReadLine();

            //imprime na tela as informações coletadas pelo usuário e guardadas na memória
            Console.Write("\n\nnome: {0} \nendereço: {1} \ntelefone: {2}", nome, endereço, telefone);

            //o comando abaixo só é inserido para manter a tela aberta após a exibição dos dados
            //até que seja apertado o enter, é um paleativo
            Console.ReadKey();
        }
    }
}
