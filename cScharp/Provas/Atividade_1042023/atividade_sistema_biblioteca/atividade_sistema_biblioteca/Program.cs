using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_sistema_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///Este é um sistema de biblioteca desenvolvido como atividade
            ///da materia de algoritmo
            /// </summary>

            //declaração de variaveis iniciais
            string usuarioLogin, senhaLogin;
            bool controle = true;
            //declaração do array de login
            string[] listaLogin = new string[3];
            listaLogin[0] = "admin";
            listaLogin[1] = "user";
            listaLogin[2] = "agent";
            //declaração do array de senha
            string[] listaSenha = new string[3];
            listaSenha[0] = "admin123";
            listaSenha[1] = "user123";
            listaSenha[2] = "agent123";
            //declaração do array de livro para serrem cadastrados
            //inicialmente vamos usar o array com 100 posições, mais para frente 
            //podemos implementar outra forma.
            Livro[] livros = new Livro[100];
            string nomeLivro, nomeAutor, nomeEditora, volumeLivro;
            int id;
            Int32 numQuantCadastro = 1;
        //

        //laço de repetição para login, caso a senha esteja errada
        //continua voltando a solicitação de login e senha
        labelMenuPrincipal:
            while (controle == true)
            {
                //solicita ao usuario o login
                Console.WriteLine("Digite seu usuario: ");
                usuarioLogin = Console.ReadLine().ToLower();
                //solicita ao usuario a senha
                Console.WriteLine("Digite sua senha: ");
                senhaLogin = Console.ReadLine().ToLower();

                //laço condicional que identifica o login e senha 
                //identifica qual usuario está logado
                if (usuarioLogin == listaLogin[0] && senhaLogin == listaSenha[0])
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido com a tag "labelAdmin:"
                    goto labelAdmin;
                    controle = false;
                }
                else if (usuarioLogin == listaLogin[1] && senhaLogin == listaSenha[1])
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido com a tag "labelUser:"
                    goto labelUser;
                    controle = false;
                }
                else if (usuarioLogin == listaLogin[2] && senhaLogin == listaSenha[2])
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido, a tag ainda não foi criada
                    controle = false;
                }
                else
                {
                    //caso não seja inserido o login ou a senha correta ele solicita que insira novamente login e senha
                    controle = true;
                    Console.Clear();
                    Console.WriteLine("Login ou senha incorreta!");

                }
            }


        //tag para onde o jumper do login de administrador pula
        labelAdmin:
            //comando clear limpa a tela
            Console.Clear();
            //declarando váriavel para quantidade de cadastros
            string quantCadastro = "n";
            
            //laço de repetição para cadastro dos livros
            for (int cadastro = 0; cadastro < numQuantCadastro; cadastro++)
            {
                //solicita ao usuario o nome do livro
                Console.WriteLine("Digite o nome do Livro: ");
                nomeLivro = Console.ReadLine();
                //solicita ao usuario o nome do autor do livro
                Console.WriteLine("Digite o nome do Autor: ");
                nomeAutor = Console.ReadLine();
                //solicita ao usuario o volume do livro
                Console.WriteLine("Digite o volume: ");
                volumeLivro = Console.ReadLine();
                //solicita ao usuario o nome da editora do livro
                Console.WriteLine("Digite o nome da Editora: ");
                nomeEditora = Console.ReadLine();

                //delcaração para id, possivel incremento caso necessário no futuro
                id = 0000 + cadastro;

                //declaração de um novo objeto de classe para inserir os dados fornecidos pelo usuario
                Livro livroCadastro = new Livro(id, nomeLivro, nomeAutor, nomeEditora, volumeLivro);
                //atribuindo o objeto dentro do array conforme a posição ordenada
                //pelo indice do laço de repetição com a variavel cadastro
                livros[cadastro] = livroCadastro;
                //pergunta ao usuario se ele deseja cadastrar outro livro
                Console.WriteLine("Deseja cadastrar outro livro? (S/N)");
                quantCadastro = Console.ReadLine();
                //laço condicional que determina se será gerado um novo campo para cadastro
                //ou será dirigido para tela inicial para efetuar um novo login
                if (quantCadastro == "s")
                {
                    numQuantCadastro++;
                }
                //comando limpa a tela após a decisão
                Console.Clear();


            }
            //comando que faz o jumper para tela principal, ou seja, o inicio do programa
            goto labelMenuPrincipal;
        //tag para onde o jumper direciona quando é o login de usuario
        labelUser:
            //comando limpa a tela para uma nova amostragem
            Console.Clear();
            //Solicita ao usuário que escolçha uma opção entre
            //esmprestimo, devolução e ver situação lilvro
            voltarMenuOpcao:
            Console.WriteLine("Digite o número da opção abaixo que deseja Efetuar" +
                "\n1 - Pegar livro emprestado" +
                "\n2 - Devolver Livro" +
                "\n3 - Ver situação do Livro"+
                "\n4 - voltar para login");
            //declaração de variaveis para receber a resposta e auxilio dos comando sequintes
            Int16 escolhaOperacao = Convert.ToInt16(Console.ReadLine());
            Int32 testeVariavel = numQuantCadastro;
            Int16 idLivroEscolhido;
            string confirmaEmprestimo;
            //em função da esolha da operação o usuário agora escolhe como quer proceder
            if (escolhaOperacao == 1)
            {
                //Solicita ao usuário para escolha a forma com a qual ele
                //ele quer usar para fazer a busca do livro
                MenuEscolhaEmprestimo:
                Console.WriteLine("digite o número da opção de como desejar procurar seu livro:" +
                    "\n1 - Pelo nome do livro" +
                    "\n2 - Pelo nome do autor" +
                    "\n3 - Pelo nome da editora"+
                    "\n4 - Voltar menu anterior");
                Int16 escolhaOperacaoEmprestimo = Convert.ToInt16(Console.ReadLine());
                
                //laço condicional das opções de procura do livro
                //cada condição efetua um comando diferente
                if (escolhaOperacaoEmprestimo == 1)
                {
                    //comando limpa a tela
                    Console.Clear();
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome do Livro: ");
                    string nomeDoLivroEmprestimo = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    Console.WriteLine("Lista de livros com o nome especificado: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarTitulo = 0; procurarTitulo < numQuantCadastro; procurarTitulo++)
                    {

                        if ((livros[procurarTitulo].titulo).Contains(nomeDoLivroEmprestimo))
                        {
                            Console.WriteLine(livros[procurarTitulo].MostrarInformacoes());
                        }
                        
                    }
                        //solicita o Id do livro ao usuario para identificação de um unico exemplar
                        Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                        idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                        //solicita confirmação para emprestimo do livro
                        Console.WriteLine("Confirma o emprestimo? (s/n)");
                        confirmaEmprestimo = Console.ReadLine().ToLower();
                        //pega os dado de confirmação do usuario e confirma o emprestimo
                        ////exibe os dados do livro emprestado
                        livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                        Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());
                        //pergunta ao usuario se ele quer fazer uma novo emprestimo
                        Console.WriteLine("\ndeseja voltar ao menu e fazer um novo emprestimo? (s/n)");
                        string voltarMenuTituloemprestimo = Console.ReadLine();
                        //condição que leva para o menu de emprestimo
                        if (voltarMenuTituloemprestimo == "s")
                        {
                            //comando limpa a tela
                            Console.Clear();
                            //comando faz um jumper para parte do menu de emprestimo
                            goto MenuEscolhaEmprestimo;
                        }
                        else
                        {
                            //comando limpa a tela
                            Console.Clear();
                        }
                    
                    
                }
                else if (escolhaOperacaoEmprestimo == 2)
                {
                    //comando limpa a tela
                    Console.Clear();
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDoAutorEmprestimoAutor = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    Console.WriteLine("Lista de livros com o nome do Autor especificado: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarAutor = 0; procurarAutor < numQuantCadastro; procurarAutor++)
                    {

                        if ((livros[procurarAutor].autor).Contains(nomeDoAutorEmprestimoAutor))
                        {
                            Console.WriteLine(livros[procurarAutor].MostrarInformacoes());
                        }
                        
                    }
                    
                        //solicita o Id do livro ao usuario para identificação de um unico exemplar
                        Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                        idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                        //solicita confirmação para emprestimo do livro
                        Console.WriteLine("Confirma o emprestimo? (s/n)");
                        confirmaEmprestimo = Console.ReadLine().ToLower();
                        //pega os dado de confirmação do usuario e confirma o emprestimo
                        //exibe os dados do livro emprestado
                        livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                        Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());
                        //pergunta ao usuario se ele quer fazer uma novo emprestimo
                        Console.WriteLine("\ndeseja voltar ao menu e fazer um novo emprestimo? (s/n)");
                        string voltarMenuAutoremprestimo = Console.ReadLine();
                        //condição que leva para o menu de emprestimo
                        if (voltarMenuAutoremprestimo == "s")
                        {
                            //comando limpa a tela
                            Console.Clear();
                            //comando faz um jumper para parte do menu de emprestimo
                            goto MenuEscolhaEmprestimo;
                        }
                        else
                        {
                            //comando limpa a tela
                            Console.Clear();
                        }
                                        
                }
                else if (escolhaOperacaoEmprestimo == 3)
                {
                    //comando limpa a tela
                    Console.Clear();
                    
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome da editora,: ");
                    string nomeEditoraEmprestimo = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    Console.WriteLine("Lista de livros com o nome da Editora especificada: ");
                    //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                    for (int procurarEditor = 0; procurarEditor < numQuantCadastro; procurarEditor++)
                    {

                        if ((livros[procurarEditor].autor).Contains(nomeEditoraEmprestimo))
                        {
                            Console.WriteLine(livros[procurarEditor].MostrarInformacoes());
                        }
                        
                    }
                    
                        //solicita o Id do livro ao usuario para identificação de um unico exemplar
                        Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                        idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                        //solicita confirmação para emprestimo do livro
                        Console.WriteLine("Confirma o emprestimo? (s/n)");
                        confirmaEmprestimo = Console.ReadLine().ToLower();
                        //pega os dado de confirmação do usuario e confirma o emprestimo
                        //exibe os dados do livro emprestado
                        livros[idLivroEscolhido].Emprestar(confirmaEmprestimo);
                        Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());
                        //pergunta ao usuario se ele quer fazer uma novo emprestimo
                        Console.WriteLine("\ndeseja voltar ao menu e fazer um novo emprestimo? (s/n)");
                        string voltarMenuEditoraemprestimo = Console.ReadLine();
                        //condição que leva para o menu de emprestimo
                        if (voltarMenuEditoraemprestimo == "s")
                        {
                            //comando limpa a tela
                            Console.Clear();
                            //comando faz um jumper para parte do menu de emprestimo
                            goto MenuEscolhaEmprestimo;
                        }
                        else
                        {
                            //comando limpa a tela
                            Console.Clear();
                        }

                }
                else if(escolhaOperacaoEmprestimo == 4)
                {
                    //comando faz u jumper para menu anterior
                    goto voltarMenuOpcao;
                    //comando limpa a tela
                    Console.Clear();
                }
                else{
                    Console.WriteLine("Opção não é válida, tente novamente");
                }
            }
            else if (escolhaOperacao == 2)
            {
                Console.WriteLine("Deseja escolher por qual opção abaixo para devolução? " +
                    "\n1 - Nome do livro" +
                    "\n2 - Nome do Autor do livro" +
                    "\n3 - Nome da Editora"+
                    "Digite o número do indice: ");
                Int16 escolhaLivroDevolucao = Convert.ToInt16(Console.ReadLine());

                if(escolhaLivroDevolucao == 1)
                {
                    Console.Clear();
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDotitulodevolucao = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    for (int procurartitulo = 0; procurartitulo < numQuantCadastro; procurartitulo++)
                    {

                        if ((livros[procurartitulo].autor).Contains(nomeDotitulodevolucao))
                        {
                            Console.WriteLine(livros[procurartitulo].MostrarInformacoes());
                        }
                        else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }
                    //solicita o Id do livro ao usuario para identificação de um unico exemplar
                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                    //solicita confirmação para emprestimo do livro
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower();
                    //pega os dado de confirmação do usuario e confirma o emprestimo
                    //exibe os dados do livro emprestado
                    livros[idLivroEscolhido].Devolver(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());

                }
                else if(escolhaLivroDevolucao == 2)
                {
                    //comando limpa a tela
                    Console.Clear();
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDoAutordevolucao = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    for (int procurarAutorDev = 0; procurarAutorDev < numQuantCadastro; procurarAutorDev++)
                    {

                        if ((livros[procurarAutorDev].autor).Contains(nomeDoAutordevolucao))
                        {
                            Console.WriteLine(livros[procurarAutorDev].MostrarInformacoes());
                        }
                        else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }
                    //solicita o Id do livro ao usuario para identificação de um unico exemplar
                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                    //solicita confirmação para emprestimo do livro
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower();
                    //pega os dado de confirmação do usuario e confirma o emprestimo
                    //exibe os dados do livro emprestado
                    livros[idLivroEscolhido].Devolver(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());
                }
                else if(escolhaLivroDevolucao == 3)
                {
                    //comando limpa a tela
                    Console.Clear();
                    //solicita ao usuario o nome do livro
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDoEditoradevolucao = Console.ReadLine();
                    //exibe a lista de livros conforme a solicitação
                    for (int procurarEditorDev = 0; procurarEditorDev < numQuantCadastro; procurarEditorDev++)
                    {

                        if ((livros[procurarEditorDev].autor).Contains(nomeDoEditoradevolucao))
                        {
                            Console.WriteLine(livros[procurarEditorDev].MostrarInformacoes());
                        }
                        else
                        {
                            Console.WriteLine("Não foi encontrado nenhum resultado!.");
                        }
                    }
                    //solicita o Id do livro ao usuario para identificação de um unico exemplar
                    Console.WriteLine("\nDigite o Id o livro que deseja pegar emprestado: ");
                    idLivroEscolhido = Convert.ToInt16(Console.ReadLine());
                    //solicita confirmação para emprestimo do livro
                    Console.WriteLine("Confirma o emprestimo? (s/n)");
                    confirmaEmprestimo = Console.ReadLine().ToLower();
                    //pega os dado de confirmação do usuario e confirma o emprestimo
                    //exibe os dados do livro emprestado
                    livros[idLivroEscolhido].Devolver(confirmaEmprestimo);
                    Console.WriteLine("\nVocê acaba de confirmar o emprestimo do livro com dados abaixo: \n{0}", livros[idLivroEscolhido].MostrarInformacoes());

                }
            }
            else if (escolhaOperacao == 3)
            {
                //comando limpa a tela
                Console.Clear();
                //solicita ao usuario o nome do livro
                Console.WriteLine("Digite o nome do autor do Livro: ");
                string nomeDoTituloSituacao = Console.ReadLine();
                //exibe a lista de livros conforme a solicitação
                Console.WriteLine("Lista de livros com o nome do Autor especificado: ");
                //Laço de repetição que percorre a quantidade de livros cadastrados no armazenamento
                for (int procurarSituacao = 0; procurarSituacao < numQuantCadastro; procurarSituacao++)
                {

                    if ((livros[procurarSituacao].autor).Contains(nomeDoTituloSituacao))
                    {
                        Console.WriteLine(livros[procurarSituacao].MostrarInformacoes());
                    }
                   
                }
            }
            else if (escolhaOperacao == 4)
            {
                //comando para limpar a tela
                Console.Clear();
                //comando que direciona para tela de login
                goto labelMenuPrincipal;
            }
            else
            {
                Console.WriteLine("Opção não é válida, tente novamente!");
            }

            goto labelMenuPrincipal;

            Console.WriteLine("Sua escolha foi " + escolhaOperacao);

        fimPrograma:
            Console.WriteLine("Obrigado e até a próxima!!!");

            Console.ReadKey();

        }


    }
}
