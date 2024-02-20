using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace do projeto
namespace Funcoes
{   
    //classe do projeto
    class Program
    {
        /*
         Autor do Projeto: Diego de Souza Lima
         nome do projeto: Funções
         data: 05/10/2023
        */
        // Estrutura para representar um animal
        struct Animal
        {
            public string Nome;
            public string Tipo;
            public int Idade;
        }

        // Lista para armazenar os animais
        static List<Animal> animais = new List<Animal>();


        static void Main(string[] args)
        {       //Laço de repetição que mantem o menu ativo para posteriores escolhas
                while (true)
                {
                    //imprime na tela o menu de escolha
                    Console.WriteLine("=== Petshop Menu ===");
                    Console.WriteLine("1. Adicionar Animal");
                    Console.WriteLine("2. Listar Animais");
                    Console.WriteLine("3. Buscar Animal por Nome");
                    Console.WriteLine("4. Sair");
                    Console.Write("Escolha uma opção: ");
                    //variavel que recebe o dado inserido pelo usuario
                    int escolha = Convert.ToInt32(Console.ReadLine());
                    //laço condicional conforme a escolha do usuario chama uma função especifica
                    switch (escolha)
                    {
                        case 1://caso a escolha seja um chama a função AdicionarAnimal
                            AdicionarAnimal();
                            break;
                        case 2://caso a escolha seja dois, chama a função Listar animais
                            ListarAnimais();
                            break;
                        case 3://caso a escolha seja três, chama a função Buscar animal
                            BuscarAnimalPorNome();
                            break;
                        case 4://caso a escolha seja quatro, sai do laço de repetição e termina o programa
                            return;
                        default://padrão que caso o digitado não seja uma opção, imprime uma mensagem
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                    //imprime ma mensagem para o usuario digitar qualquer coisa para continuar
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    //comando que segura a rendenizalçao da tela e não deixa fechar ou voltar ao inicio antes do usuario precionar qualquer tela
                    Console.ReadKey();
                    //comando que limpa os dados da tela antes impressos
                    Console.Clear();
                }
         }
        //função de cadastro de animais
         static void AdicionarAnimal()
         {      //instanciando o objeto nimal para uso na função
                Animal animal = new Animal();
                //imprime para o usuario uma pergunta
                Console.Write("Nome do animal: ");
                //recebe a resposta do usuario e guarda no objeto
                animal.Nome = Console.ReadLine();
                //imprime para o usuario uma pergunta
                Console.Write("Tipo do animal: ");
                //recebe a resposta do usuario e guarda no objeto
                animal.Tipo = Console.ReadLine();
                //imprime para o usuario uma pergunta
                Console.Write("Idade do animal: ");
                //recebe a resposta do usuario e guarda no objeto
                animal.Idade = Convert.ToInt32(Console.ReadLine());
                //inclui os dados recebido dentro do arrays 
                animais.Add(animal);
                //imprime a mensagem de confirmação de cadastro
                Console.WriteLine("Animal adicionado com sucesso!");
         }
        //Função para listar os animais cadastrados
         static void ListarAnimais()
         {      //laço condicional que verifica se tem animais cadastrados no array
                if (animais.Count > 0)
                {   //caso tenha animais dentro do arrya imprime a parte inicial com os dados
                    Console.WriteLine("=== Lista de Animais ===");
                    //laço de repetição que percore o array imprimindo os animais cadastrados
                    foreach (var animal in animais)
                    {   //imprime os animais do array na tela
                        Console.WriteLine($"Nome: {animal.Nome}, Tipo: {animal.Tipo}, Idade: {animal.Idade}");
                    }
                }
                else
                {   //imprime uma mensagem de sem cadastro
                    Console.WriteLine("Nenhum animal cadastrado.");
                }
          }
            //Função usada para busca de animais cadastrados dentro do array
          static void BuscarAnimalPorNome()
          {     //imprime na tela uma mensagem que pergunta qual animal deseja buscar
                Console.Write("Digite o nome do animal a ser buscado: ");
                //recebe o dado digitado e coloca em uma variavel
                string nomeBusca = Console.ReadLine();
                //declaração de variavel para confirmação de conclusão
                bool encontrado = false;
                //laço de repetição que percorre o array de animais
                foreach (var animal in animais)
                {   //laço condicional que verifica se o dados digitado pelo usuario confere com algum animal no array
                    if (animal.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                    {   //caso seja achado, imprime os dados do animal na tela
                        Console.WriteLine($"Nome: {animal.Nome}, Tipo: {animal.Tipo}, Idade: {animal.Idade}");
                    //seta a variavel de confirmação de conclusão
                        encontrado = true;
                    }
                }
                //laço condicional que imprime na tela mensagem de confirmação da busca
                if (!encontrado)
                {   //mensagem de confirmação da busca
                    Console.WriteLine("Animal não encontrado.");
                }
          }
        

    }

}
