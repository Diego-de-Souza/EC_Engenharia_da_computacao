using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_N2_EC2_algoritmo_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionarios = new Funcionarios();
            string cargoNovo;
            Int32 idade;
            decimal salario, aumentoSalario;


            Console.WriteLine("Digite o nome do funcionario: ");
            funcionarios.nome = Console.ReadLine();
            Console.WriteLine("Qual o cargo do funcionário: ");
            cargoNovo = Console.ReadLine();
            Console.WriteLine("Qual o valor do salário: ");
            salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano o funcionario nasceu: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de aumento do salário?  ");
            aumentoSalario = decimal.Parse(Console.ReadLine());

            //metodos
            funcionarios.alterarCargo(cargoNovo);
            funcionarios.aumentarSalario(salario,aumentoSalario);
            funcionarios.aniversario(idade);

            Console.WriteLine(funcionarios.mostraInformacoes());
      

            //fim do programa
            Console.ReadKey();
        }
    }
}
