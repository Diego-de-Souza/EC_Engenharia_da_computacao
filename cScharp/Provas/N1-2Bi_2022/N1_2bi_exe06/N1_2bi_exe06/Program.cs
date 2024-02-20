using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de dados
            string senhaCorreta="teste", senhaInserida, liberaAcesso="negado";
            //Solicita a senha para o usuário
            Console.Write("Digite a senha: ");
            //faz a condição de confirmação da senha
            while (liberaAcesso == "negado") {
                senhaInserida = Console.ReadLine();
                if (senhaInserida != senhaCorreta)
                {
                    Console.Write("ACESSO NEGADO \nTente novamente: ");
                } else
                {
                    Console.Write("ACESSO PERMITIDO ");
                    liberaAcesso = "liberado";
                }
            }
            Console.ReadKey();
        }
    }
}
