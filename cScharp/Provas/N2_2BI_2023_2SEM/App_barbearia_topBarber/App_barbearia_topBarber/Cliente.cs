using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_barbearia_topBarber
{
    class Cliente
    {
        //declaração de atributos
        public string nomeCliente;
        private string telefone;
        private string endereco;
        private string formaDePagamento;
        private string email;
        private string nomeConsulta;

        //Criação de metodos do cliente
        public void CadastroCLiente()
        {
            //codigo da do metodo cadastro cliente, que seta os dados do cliente
            Console.WriteLine("------------ Cadastro de cliente ------------");
            Console.WriteLine("Digite o nome do cliente: ");
            nomeCliente = Console.ReadLine();
            Console.WriteLine("Digite o telefone do cliente: ");
            telefone = Console.ReadLine();
            Console.WriteLine("DIgite o endereço do cliente:");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o email do cliente: ");
            email = Console.ReadLine();
            Console.WriteLine("cliente cadastrado com sucesso!");
            Console.ReadKey();
        }

        public void ConsultaCliente()
        {
            //codigo do metodo consulta cliente , que busca os dados do cliente
            Console.WriteLine("------------ Consulta Cliente ------------ ");
            Console.WriteLine("Digite o nome do cliente na qual deseja consultar: ");
            nomeConsulta = Console.ReadLine();

            if(nomeConsulta == nomeCliente)
            {
                Console.WriteLine("Dados do cliente:" +
                                    "nome:"+nomeCliente+
                                    "telefone:"+telefone+
                                    "email:"+email+
                                    "endereco"+endereco);
            }
            else
            {
                Console.WriteLine("Desculpe, não existe cliente com este nome:");
            }
        }
        public void FormaDePagamento()
        {
            //codigo do metodo forma de pagamento, dizendo a forma de pagamento do cliente
            Console.WriteLine("------------ Forma de pagamento ------------");
            Console.WriteLine("DIgite a forma de pagamento: " +
                            "1 - dinheiro" +
                            "2 - cartão de Débito" +
                            "3 - cartão de crédito" +
                            "4 - PIX" +
                            "5 - trasnferencia bancária");

        }

    }
}
