using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Classe
{
    class Animais
    {
        //declarando as váriaveis -> atributos
        private string Nome;
        private string Especie;
        private DateTime DataNasc;
        private string Raca;
        private float Peso;


        //delcaração dos métodos da função.
        public void Cadastrar()
        {
            Console.WriteLine("---> Cadastro de Animais");
            Console.WriteLine("Digite o nome: ");
            this.Nome = Console.ReadLine();
           
            Console.WriteLine("Digite a especie: ");
            this.Especie = Console.ReadLine();

            Console.WriteLine("Digite a raça: ");
            this.Raca = Console.ReadLine();

            Console.WriteLine("Digite dua data de nascimento. \r Formato: gg,mm.ys");
            DataNasc = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso/; ");
            this.Peso = float.Parse(Console.ReadLine());
        }

        public void Excluir()
        {
            this.Nome = null;
            this.Especie = null;
            this.Raca = null;
            this.DataNasc = DateTime.MinValue;
            this.Peso = 0;
        }

        public void LimparDados()
        {

        }

        public void Alterar()
        {
            Console.WriteLine("---> Alteração de dados <---");
            Console.Write("Nome:");
            this.Nome = Console.ReadLine();

            Console.WriteLine("Digite a especie: ");
            this.Especie = Console.ReadLine();

            Console.WriteLine("Digite a raça: ");
            this.Raca = Console.ReadLine();

            Console.WriteLine("Digite dua data de nascimento. \r Formato: gg,mm.ys");
            DataNasc = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso/; ");
            this.Peso = float.Parse(Console.ReadLine());
        }
    }
    }

