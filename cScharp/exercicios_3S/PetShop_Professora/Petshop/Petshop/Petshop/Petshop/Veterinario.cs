using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
	public class Veterinario
	{

		//atributos
		private string nomeVet;
		private string especialidade;
		private string crmv;
		private int diasDeTrabalho;

		public Veterinario()
		{

		}
		
		public void AdicionarVet()
        {
			Console.WriteLine("---->Cadastro Veterinario<----");
			Console.WriteLine("Informe o nome do Veterinário: ");
			nomeVet = Console.ReadLine();

		}
		public void ConsultarVet()
        {
			Console.WriteLine("---->Consulta Veterinario<----");
			Console.WriteLine("Informe o nome do Veterinário: ");
			nomeVet = Console.ReadLine();
		}
		public void alterarVet()
        {

        }
		public void ExcluirVet()
        {

        }


	}

}


