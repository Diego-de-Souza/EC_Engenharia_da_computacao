using Atividade_sistema_biblioteca_20230404;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace atividade_algoritmo_04042023
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
            bool controle=true;
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
        //

        //laço de repetição para login, caso a senha esteje errada
        //continua voltando a solicitação de login e senha
        labelMenuPrincipal:
            while (controle == true) {
                
                Console.WriteLine("Digite seu usuario: ");
                usuarioLogin = Console.ReadLine().ToLower();
                Console.WriteLine("Digite sua senha: ");
                senhaLogin = Console.ReadLine().ToLower();

                //laço condicional que identifica o login e senha 
                //identifica qual usuario está logado
                if(usuarioLogin == listaLogin[0] && senhaLogin == listaSenha[0])
                {
                    goto labelAdmin;
                    controle = false;
                }else if(usuarioLogin == listaLogin[1] && senhaLogin == listaSenha[1])
                {
                    goto labelUser;
                    controle=false;
                }else if(usuarioLogin == listaLogin[2] && senhaLogin == listaSenha[2])
                {
                    controle = false;
                }else
                {
                    controle = true;
                    Console.Clear();
                    Console.WriteLine("Login ou senha incorreta!");
                    
                }
            }



        labelAdmin:
            Console.Clear();
            string quantCadastro = "n";
            Int32 numQuantCadastro = 1;
            
            for (int cadastro = 0; cadastro < numQuantCadastro; cadastro++)
            {
                Console.WriteLine("Digite o nome do Livro: ");
                nomeLivro = Console.ReadLine();
                Console.WriteLine("Digite o nome do Autor: ");
                nomeAutor = Console.ReadLine();
                Console.WriteLine("Digite o volume: ");
                volumeLivro = Console.ReadLine();
                Console.WriteLine("Digite o nome da Editora: ");
                nomeEditora = Console.ReadLine();

                id = 0000 + cadastro;

                Livro livroCadastro = new Livro(id,nomeLivro,nomeAutor,nomeEditora,volumeLivro);
                livros[cadastro] = livroCadastro;

                Console.WriteLine("Deseja cadastrar outro livro? (S/N)");
                quantCadastro = Console.ReadLine();
                if(quantCadastro == "s")
                {
                    numQuantCadastro++;
                }
                Console.Clear();

                
            }

        goto labelMenuPrincipal;

        labelUser:
            //comando limpa a tela para uma nova amostragem
            Console.Clear();
            //Solicita ao usuário que escolçha uma opção entre
            //esmprestimo, devolução e ver situação lilvro
            Console.WriteLine("Digite o número da opção abaixo que deseja Efetuar" +
                "\n1 - Pegar livro emprestado" +
                "\n2 - Devolver Livro" +
                "\n3 - Ver situação do Livro");
            Int16 escolhaOperacao = Convert.ToInt16(Console.ReadLine());
            //em função da esolha da operação o usuário agora escolhe como quer proceder
            if(escolhaOperacao == 1)
            {
                //Solicita ao usuário para escolha a forma com a qual ele
                //ele quer usar para fazer a busca do livro
                Console.WriteLine("digite o número da opção de como desejar procurar seu livro:" +
                    "\n1 - Pelo nome do livro" +
                    "\n2 - Pelo nome do autor" +
                    "\n3 - Pelo nome da editora" +
                    "\n4 - Pela disponibilidade");
                Int16 escolhaOperacaoEmprestimo = Convert.ToInt16(Console.ReadLine());
                
                if(escolhaOperacaoEmprestimo == 1)
                {
                    
                    Console.WriteLine("Digite o nome do Livro: ");
                    string nomeDoLivroEmprestimo = Console.ReadLine();
                    for(int procurarTitulo=1;procurarTitulo < livros.Length; procurarTitulo++)
                    {
                        string teste1 = livros[procurarTitulo-1].ToString();
                        if (teste1 == nomeDoLivroEmprestimo)
                        {
                            Console.WriteLine(livros[procurarTitulo-1].titulo);
                        }
                        
                    }
                    Console.Write("o livro é {0}", nomeDoLivroEmprestimo);
                    
                }else if(escolhaOperacaoEmprestimo == 2)
                {
                    Console.WriteLine("Digite o nome do autor do Livro: ");
                    string nomeDoAutorEmprestimoAutor = Console.ReadLine();

                }
                else if(escolhaOperacaoEmprestimo == 3)
                {
                    Console.WriteLine("Digite o nome da editora,: ");
                    string nomeEditoraEmprestimo =  Console.ReadLine();

                }
                else if(escolhaOperacaoEmprestimo == 4)
                {
                    Console.WriteLine("Qual situação desjeja ver: "+"\ncontinuar procurando" );
                    string sitauacaoLivroEmprestimo = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Opção não é válida, tente novamente");
                }
            }
            else if(escolhaOperacao == 2)
            {

            }else if(escolhaOperacao == 3)
            {

            }else
            {
                Console.WriteLine("Opção não é válida, tente novamente!");
            }

        goto labelMenuPrincipal;

            Console.WriteLine("Sua escolha foi "+escolhaOperacao);

        fimPrograma:
            Console.WriteLine("Obrigado e até a próxima!!!");

            Console.ReadKey();

        }

        
    }

    public class Admin
    {
        public static void SystemAdmin(string[] args)
        {
       
            Console.WriteLine("Teste deu certo!!");
        }
    }
}
