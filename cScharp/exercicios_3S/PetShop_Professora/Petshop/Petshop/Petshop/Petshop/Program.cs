using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animais animal = new Animais();
            ConsultaMedica consulta = new ConsultaMedica();
            Veterinario veterinario = new Veterinario();

            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("Menu Principal:");
                    Console.WriteLine("1 - Animais");
                    Console.WriteLine("2 - Consulta");
                    Console.WriteLine("3 - Sair do programa");

                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("--> Menu - Animais <--");
                            Console.WriteLine("1 - Cadastrar animal");
                            Console.WriteLine("2 - Consultar animal");
                            Console.WriteLine("3 - Alterar animal");
                            Console.WriteLine("4 - Excluir animal");
                            Console.WriteLine("5 - Voltar ao menu anterior");
                            Console.Write("Escolha uma opção: ");

                            int opcao1 = int.Parse(Console.ReadLine());

                            switch (opcao1)
                            {
                                case 1:
                                    animal.Cadastrar();
                                    break;

                                case 2:
                                    animal.Consultar();
                                    break;

                                case 3:
                                    animal.Alterar();
                                    break;

                                case 4:
                                    animal.Excluir();
                                    break;

                                case 5:
                                    continuar = false;
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("--> Menu - Consulta <--");
                            Console.WriteLine("1 - Agendamento de Consulta");
                            Console.WriteLine("2 - Registro de Consulta");
                            Console.WriteLine("3 - Exibir registro da Consulta");
                            Console.WriteLine("4 - Voltar ao menu anterior");

                            int opcao2 = int.Parse(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 1:
                                    consulta.AgendarConsulta();
                                    break;

                                case 2:
                                    consulta.RegistrarConsulta();
                                    consulta.ExibirConsulta();
                                    break;

                                case 3:
                                    consulta.ExibirConsulta();
                                    break;

                                case 4:
                                    continuar = false;
                                    break;

                                default:
                                    Console.WriteLine("Opção inválida.");
                                    break;
                            }

                            break;

                        
                    }
                    

                    Console.WriteLine();
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
        }
    }
}
