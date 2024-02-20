using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class Animais
    {
        private string nome;
        private DateTime dataNascimento;
        private string especie;
        private string raca;
        private float peso;

        public void Cadastrar()
        {
            Console.WriteLine("-->Cadastro de Animal<--");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
            dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Espécie: ");
            especie = Console.ReadLine();
            Console.Write("Raça: ");
            raca = Console.ReadLine();
            Console.Write("Peso: ");
            peso = int.Parse(Console.ReadLine());
        }

        // Método para exibir os detalhes do animal
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToShortDateString()}");
            Console.WriteLine($"Espécie: {especie}");
            Console.WriteLine($"Raça: {raca}");
            Console.WriteLine($"Peso: {peso}");
        }

        public void Alterar()
        {
            Console.WriteLine("-->Alteração de Dados do Animal<--");
            try
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Data de Nascimento (dd/mm/aaaa): ");
                dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Espécie: ");
                especie = Console.ReadLine();
                Console.Write("Raça: ");
                raca = Console.ReadLine();
                Console.Write("Peso: ");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Dados do animal alterados com sucesso!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Formato inválido para data ou peso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public void Consultar()
        {
                Console.Write("Digite o nome do animal a ser consultado: ");
                string nomeConsulta = Console.ReadLine();

                if (nomeConsulta == nome)
                {
                    ExibirDetalhes();

                    Console.WriteLine("\nSubmenu:");
                    Console.WriteLine("1 - Alterar dados");
                    Console.WriteLine("2 - Excluir dados");
                    Console.WriteLine("3 - Voltar ao menu anterior");
                    Console.Write("Escolha uma opção: ");
                    int submenuOpcao = int.Parse(Console.ReadLine());

                    switch (submenuOpcao)
                    {
                        case 1:
                            Alterar();
                            break;

                        case 2:
                            Excluir();
                            break;

                        case 3:
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Voltando ao menu anterior.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Animal não encontrado.");
                }
            
        }

        public void Excluir()
        {
            // Define os campos como valores padrão
            nome = string.Empty;
            dataNascimento = DateTime.MinValue;
            especie = string.Empty;
            raca = string.Empty;
            peso = 0.0f;
            Console.WriteLine("Animal excluído com sucesso!");
        }
    }
}
