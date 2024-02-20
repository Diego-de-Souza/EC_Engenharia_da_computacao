using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_0411_pesquisa_sequencial_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[5];
            string procura;

            //entrada de dados
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Digite Nome {i}: ");
                nomes[i] = Console.ReadLine();
            }

            //quem procurar
            Console.Write("Digite o nome para procurar: ");
            procura = Console.ReadLine();


            //fazendo a procura
            bool achei = false;
            for (int i = 0; i < nomes.Length; i++)
            {
                //verifica se é igual ao vetor
                if (nomes[i] == procura) {
                    achei = true; //indica que achou pelo menos 1
                    Console.WriteLine($"Encontrei na posição {i}");
                }
            }

            if (!achei)//se não achoi ninguem
                Console.WriteLine("Nome não encontrado...");


        }
    }
}