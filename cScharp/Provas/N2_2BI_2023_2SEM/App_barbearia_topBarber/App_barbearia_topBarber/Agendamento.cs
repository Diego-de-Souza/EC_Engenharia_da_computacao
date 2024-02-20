using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_barbearia_topBarber
{
    
    class Agendamento
    {
        Cliente clientes = new Cliente();
        Funcionario funcionarios = new Funcionario();
        //atributos
        private string nomeAgendamento;
        private string nomeAtendente;
        private string nomeProf;
        private string dataAgendamento;

        public void AgendamentoBarbearia()
        {
            Console.WriteLine("------------ Agendamento ------------");
            Console.WriteLine("Deseja agendar para qual profissional: ");
            nomeAtendente = Console.ReadLine();
            Console.WriteLine("Digite as hora do Agendamento Ex(00-00-0000): ");
            dataAgendamento = Console.ReadLine();
            Console.WriteLine("Digite o nome do cliente que vai ser atendido: ");
            nomeAgendamento = Console.ReadLine();
            Console.WriteLine("Agendamento cadastrado com sucesso!");
            Console.ReadKey();
        }
    }
}
