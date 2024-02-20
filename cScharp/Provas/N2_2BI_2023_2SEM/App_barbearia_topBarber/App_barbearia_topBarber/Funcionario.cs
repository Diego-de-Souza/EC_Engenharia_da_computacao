using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_barbearia_topBarber
{
    class Funcionario
    {
        //declaração de atributos
        public string nomeFuncionario;
        private int idFuncionario;
        private string telefoneFuncionario;
        private string cargoFuncionario;
        private string nomeConsulta;

        public void CadastroFuncionario()
        {
            //codigo da do metodo cadastro cliente, que seta os dados do cliente
            Console.WriteLine("------------ Cadastro de funcionario ------------");
            Console.WriteLine("Digite o nome do funcionario: ");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine("DIgite o telefone do funcionário:");
            telefoneFuncionario = Console.ReadLine();
            Console.WriteLine("Digite o cargo do funcionário: ");
            cargoFuncionario = Console.ReadLine();
            Console.WriteLine("funcionario cadastrado com sucesso!");
            Console.ReadKey();
        }

        public void ConsultaFuncionário()
        {
            //codigo do metodo consulta cliente , que busca os dados do cliente
            Console.WriteLine("------------ Consulta Funcionario ------------ ");
            Console.WriteLine("Digite o nome do funcionario na qual deseja consultar: ");
            nomeConsulta = Console.ReadLine();

            if (nomeConsulta == nomeFuncionario)
            {
                Console.WriteLine("Dados do funcionario:" +
                                    "ID:" + idFuncionario +
                                    "nome:" +nomeFuncionario  +
                                    "telefone:" + telefoneFuncionario +
                                    "cargo" + cargoFuncionario);
            }
            else
            {
                Console.WriteLine("Desculpe, não existe funcionário com este nome:");
            }
        }

    }
}
