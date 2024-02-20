using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação de algumas váriaveis
            string nomeSubpasta = "MeusArquivos";
            string pastaDoocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pastaDestino = Path.Combine(pastaDoocumentos, nomeSubpasta);

            //Verificar se a subpasta "Meus Arquivos" exite
            //Criar se necessário
            if (!Directory.Exists(pastaDestino))
            {
                Directory.CreateDirectory(pastaDestino);
            }

            while (true)
            {
                //Cria um menu interativo para faer manipulação de arquivos
                Console.WriteLine("Bem vindos ap arquivater");
                Console.WriteLine("Escolha a opção desejeda");
                Console.WriteLine("1 - Criar arquivo novo \n" +
                                  "2 - Adicionar conteúdo \n" +
                                  "3 - Substituir conteúdo de Arquivo \n" +
                                  "4 - Ler Arquivo \n" +
                                  "5 - Sair");

                try
                {
                    int escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            //solicita ao usuario o nome do arquivo
                            Console.WriteLine("Digite o seu nome do arquivo (se, extensão): ");
                            string nomeArquivo = Console.ReadLine();

                            string nomeArquivoExtensao = nomeArquivo + "txt";
                            string caminhoArquivo = Path.Combine(pastaDestino, nomeArquivoExtensao);

                            //Criar um arquivo vazio
                            File.WriteAllText(caminhoArquivo, string.Empty);
                            Console.WriteLine($"Arquivo `{nomeArquivoExtensao}` foi criado na pasta `{pastaDestino}`");
                            break;
                        case 2:
                            //Adicionar conteúdo no arquivo
                            Console.WriteLine("Digite o nome do Arquivo para adicionar conteúdo: ");
                            string arquivoAdicionar = Console.ReadLine();

                            //Verifica se o arquivo existe
                            if (!File.Exists(pastaDestino + "\\" + arquivoAdicionar + ".txt"))
                            {
                                Console.WriteLine($"O arquivo '{arquivoAdicionar}` não existe na pasta `{pastaDestino}`");
                            }

                            //Solicitar ao usuario para adicionar conteúdo desejado
                            Console.WriteLine("Digite o conteúdo a ser adicionado: ");
                            string conteudoAdicionado = Console.ReadLine();

                            File.AppendAllText(pastaDestino + "\\" + arquivoAdicionar + ".txt", conteudoAdicionado + Environment.NewLine);
                            Console.WriteLine($"Conteúdo adicionado ao arquivo `{arquivoAdicionar}`");
                            break;
                        case 3:
                            //Substituir conteúdo no arquivo
                            Console.WriteLine("Digite o nome do arquivo para substituir conteúdo (sem extensão): ");
                            string arquivoSubstituir = Console.ReadLine();

                            //Verificase o arquivo existe
                            if (!File.Exists(pastaDestino + "\\" + arquivoSubstituir + ".txt"))
                            {
                                Console.WriteLine($"O arquivo `{arquivoSubstituir}` não existe na pasta `{pastaDestino}`");
                            }

                            //Solicite ao usuario para adicionar conteúdo desejado
                            Console.WriteLine("Digite o conteúdo a ser substituido: ");
                            string conteudoSubstituir = Console.ReadLine();

                            File.WriteAllText(pastaDestino + "\\" + arquivoSubstituir + ".txt", conteudoSubstituir + Environment.NewLine);
                            Console.WriteLine($"Conteúdo adicionado ao arquivo `{arquivoSubstituir}`");
                            break;
                        case 4:
                            //Solicita ao usuario o arquivo á ser lido
                            Console.WriteLine("Digite o nome do arquivo a ser lido: ");
                            string arquivoLeitura = Console.ReadLine();
                            string caminhoLeitura = Path.Combine(pastaDestino, arquivoLeitura + ".txt");

                            //Verifica se o arquivo existe
                            if (!File.Exists(caminhoLeitura))
                            {
                                Console.WriteLine($"O arquivo `{arquivoLeitura}` não existe na pasta `{pastaDestino}`");
                            }

                            //Ler o conteúdo do arquivo desejado
                            string conteudoLeitura = File.ReadAllText(caminhoLeitura);
                            //Exibir o conteúdo do arquivo desejado
                            Console.WriteLine($"Conteúdo do arquivo `{arquivoLeitura}`: \n" + conteudoLeitura + Environment.NewLine);
                            break;
                        case 5:
                            //Sair do programa
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um número válido entre 1 e 5");
                }
            }
        }
    }
}
