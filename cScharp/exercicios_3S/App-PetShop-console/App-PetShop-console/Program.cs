using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PetShop_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando objeto
            Animais animais = new Animais();
            Mamiferos mamiferos = new Mamiferos();
            Aves aves = new Aves();
            Insetos insetos = new Insetos();
            Servicos servicos = new Servicos();
            bool continuar = true;
            bool continuarS = true;
            bool continuarE = true;

            //nomeando o titulo do console
            Console.Title = "APP - PetShop";
            //laço que garante a repetição das opções
            opcaoPrincipal:
            Console.Clear();
            while (continuar)
            {
                //Tela principal
                Console.WriteLine("======================================================");
                Console.WriteLine("----------> Bem vindos ao PetShop da Villa <----------");
                Console.WriteLine("======================================================");
                Console.WriteLine(" Escolha a opção desejada: ");
                Console.WriteLine(
                    "   1 - Cadastrar animal\n"+
                    "   2 - Consultar animal\n"+
                    "   3 - Alterar animal\n" +
                    "   4 - Excluir animal\n"+
                    "   5 - Serviços\n"+
                    "   6 - Sair do Programa"  );
                Console.WriteLine("------------------------------------------------------");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        animais.Cadastrar();
                        break;
                    case 2:
                        animais.Consultar();
                        break;
                    case 3:
                        animais.Alterar();
                        break;
                    case 4:
                        animais.Excluir();
                        break;
                    case 5:
                        goto opcaoServicos;
                        break;
                    case 6:
                        Console.WriteLine(" Obrigado por utilizar. Até logo!");
                        continuar=false;
                        break;
                    default:
                        Console.WriteLine(" Opção inválida!");
                        break;
                }
            }

            opcaoServicos:
            while (continuarS) { 
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("---------------------> Serviços <---------------------");
                Console.WriteLine("======================================================");
                Console.WriteLine(" Escolha a opção desejada: ");
                Console.WriteLine(
                   "   1 - Hospedagem\n"+
                   "   2 - Serviços Vegetarianos\n"+
                   "   3 - Taxi\n" +
                   "   4 - Delivery\n"+
                   "   5 - Especificos\n"+
                   "   6 - Voltar ao menu Principal\n"+
                   "   7 - Sair do programa");
                Console.WriteLine("------------------------------------------------------");
                int opcaoS = int.Parse(Console.ReadLine());
                switch (opcaoS)
                {
                    case 1:
                        servicos.Hospedagem(animais.Nome);
                        break;
                    case 2:
                        servicos.ServicosVeterinarios(animais.Especie);
                        break;
                    case 3:
                        servicos.Taxi();
                        break;
                    case 4:
                        servicos.Delivery();
                        break;
                    case 5: 
                        goto opcaoEspecifico;
                        break;
                    case 6:
                        goto opcaoPrincipal;
                        break;
                    case 7:
                        Console.WriteLine(" Obrigado por utilizar. Até logo!");
                        continuar=false;
                        break;
                    default:
                        Console.WriteLine(" Opção inválida!");
                        break;
                }
            }

            opcaoEspecifico:
            Console.Clear();
            int tipoEspecifico=0;
            if(animais.Especie == 1)
            {
                tipoEspecifico = 1;
            }else if(animais.Especie == 2)
            {
                tipoEspecifico = 2;
            }
            else
            {
                Console.WriteLine("Animal não Cadastrado, Deseja cadastrar? (s/n) ");
                string opcaoTipoAnimal = Console.ReadLine().ToLower();
                if(opcaoTipoAnimal == "s")
                {
                    goto opcaoPrincipal;
                }else
                {
                    goto opcaoServicos;
                }
            }
            Console.Clear();
            while (continuarE) { 
                Console.Clear();
                Console.WriteLine("======================================================");
                Console.WriteLine("-------------------> Especificos <--------------------");
                Console.WriteLine("======================================================");
                Console.WriteLine(" Escolha a opção desejada: ");
                Console.WriteLine(
                   "   1 - Banho\n"+
                   "   2 - Dados adjacentes\n"+
                   "   3 - Voltar ao menu anterior");
                Console.WriteLine("------------------------------------------------------");
                int opcaoE = int.Parse(Console.ReadLine());
                switch (opcaoE)
                {
                    case 1:
                        if(tipoEspecifico == 1)
                        {
                            mamiferos.BanhoETosa();
                        }else
                        {
                            aves.BanhoAve();
                        }
                        break;
                    case 2:
                        if(tipoEspecifico == 1)
                        {
                            mamiferos.DadosManifero();
                        }else
                        {
                            aves.DadosAve();
                        }
                        break;
                    case 3:
                        goto opcaoServicos;
                        break;
                    default:
                        Console.WriteLine(" Opção inválida!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
