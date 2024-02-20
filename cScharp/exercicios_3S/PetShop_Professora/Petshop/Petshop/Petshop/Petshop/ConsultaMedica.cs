using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class ConsultaMedica
    {
        //Atributos
        private DateTime dataConsulta;
        private string motivoConsulta;
        private string tratamento;

        //Metodos
        public void AgendarConsulta()
        {
            Console.WriteLine("---->Agendamento Consulta<----");
            Console.WriteLine("Informe a data desejada para agendar (dd/mm/aaaa): ");
            dataConsulta = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("A consulta do seu pet será em: " + dataConsulta);
            /*Se faz necessário incluir qual o animal  e qual
             * veterinario e sua respectiva especialidade
             */
        }

        //Metodo para registrar o decorrer da consulta
        public void RegistrarConsulta()
        {
            Console.WriteLine("---->Consulta do Pet<----");
            dataConsulta = DateTime.Now;
            Console.WriteLine("Data da Consulta: " + dataConsulta);
            Console.WriteLine("Informe o motivo da consulta: ");
            motivoConsulta = Console.ReadLine();
            Console.WriteLine("Informe o tratamento indicado ou outro(s) procedimento(s)");
            tratamento = Console.ReadLine();
        }

        public void ExibirConsulta()
        {
            Console.WriteLine("---->Dados cadastrados<----");
            Console.WriteLine($"Data da consulta: {dataConsulta}");
            Console.WriteLine($"Motivo da consulta: {motivoConsulta}");
            Console.WriteLine($"Tratamento ou outros procedimentos: {tratamento}");
        }
    }
}