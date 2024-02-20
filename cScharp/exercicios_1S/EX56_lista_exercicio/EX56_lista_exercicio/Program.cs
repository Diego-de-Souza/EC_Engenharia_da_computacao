using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX56_lista_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[50];
            Double[] salarios = new Double[50];
            Double menorSalario;
            Int16 qtdCadastro = 0;
            String resp;

            do
            {
                //Adiciona 1 na quantidade de cadastrados
                qtdCadastro++;
                Console.Write($"Nome[{qtdCadastro}]: ");
                nomes[qtdCadastro - 1] = Console.ReadLine();

                do
                {
                    Console.Write($"Salários[{qtdCadastro}]: ");
                    salarios[qtdCadastro - 1] = Convert.ToDouble(Console.ReadLine());
                } while (salarios[qtdCadastro - 1] < 0 || salarios[qtdCadastro - 1] > 15000);

                Console.Write("Deseja Cadastrar outro (S/N): ");
                resp = Console.ReadLine();
            } while (resp.ToUpper()[0] == 'S');

            //Descobrindo o menor salario
            menorSalario = salarios[0];
            for (int pos=1; pos <qtdCadastro; pos++)
            {
                if (salarios[pos] < menorSalario)
                {
                    menorSalario = salarios[pos];
                }
            }
        
        
        }
    }
}

