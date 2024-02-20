using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1_14032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializa um objeto vetor para guardar as informações dos alunos.
            Aluno[] alunos = new Aluno[5];
            string nome;
            Int32 idade;
            double nota1, nota2;


            Console.WriteLine("Digite as informações de 5 alunos");

            for (int reg = 0; reg <= 4; reg++)
            {
                //Solicita o nome do Aluno
                Console.WriteLine("Qual o nome do " + (reg + 1) + "° aluno: ");
                nome = Console.ReadLine();
                Console.WriteLine("Qual a idade do aluno: ");
                idade = Int32.Parse(Console.ReadLine());

                //cria um objeto do tipo classe para alocar as informações
                Aluno alunoCadastro = new Aluno(nome, idade);

                //solicita as notas dos alunos
                Console.Write("Digite a primeira nota do aluno: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do aluno: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                //escreve o numero das variaveis na classe
                alunoCadastro.calcularMediaFinal(nota1, nota2);
                alunoCadastro.Aprovar();

                alunos[reg] = alunoCadastro;
            }

            for(int regs = 0;regs <= 4; regs++) 
            {
                Console.WriteLine($"Aluno: {alunos[regs].nome}");
                Console.WriteLine($"Idade: {alunos[regs].idade}");
                Console.WriteLine($"Status: {alunos[regs].aprovacao}");
            }

            Console.ReadKey();
        }
    }
}
