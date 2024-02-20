using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_barbearia_topBarber
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de um objeto
            Cliente dadosCliente = new Cliente();
            Funcionario dadosFuncionario = new Funcionario();
            Agendamento agendamento = new Agendamento();

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("------------ Menu ------------");
                Console.WriteLine("1. Cadastrar Cliente");
                Console.WriteLine("2. Cadastrar Funcionário");
                Console.WriteLine("3. Agendar Serviço");
                Console.WriteLine("4. Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        dadosCliente.CadastroCLiente();
                        Console.WriteLine("Cliente cadastrado com sucesso");
                        
                        break;
                    case 2:
                        dadosFuncionario.CadastroFuncionario();
                        
                        break;
                    case 3:
                        agendamento.AgendamentoBarbearia();
                        
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                

            }
        }
    }

}
    
