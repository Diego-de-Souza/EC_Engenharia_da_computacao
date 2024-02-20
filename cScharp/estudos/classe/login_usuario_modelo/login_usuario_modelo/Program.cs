using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_usuario_modelo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //delcaração da classe como objeto
            LoginUsuario identificacaoUser = new LoginUsuario();

            while (identificacaoUser.controle == "true")
            { 
                //teste
                string msg;

                //solicita ao usuario o login
                Console.WriteLine("Digite seu usuario: ");
                identificacaoUser.usuarioLogin = Console.ReadLine().ToLower();
                //solicita ao usuario a senha
                Console.WriteLine("Digite sua senha: ");
                identificacaoUser.senhaLogin = Console.ReadLine().ToLower();

                identificacaoUser.VerificaUsuario(identificacaoUser.usuarioLogin, identificacaoUser.senhaLogin);
                //laço condicional que identifica o login e senha 
                //identifica qual usuario está logado
                if (identificacaoUser.verificacaoUsuario == "master")
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido com a tag "labelAdmin:"
                    //goto labelAdmin;
                    msg = "Administrador ok";
                    Console.WriteLine(msg);
                }
                else if (identificacaoUser.verificacaoUsuario == "user")
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido com a tag "labelUser:"
                    //goto labelUser;
                    msg = "usuario padrão ok";
                    Console.WriteLine(msg);
                }
                else if (identificacaoUser.verificacaoUsuario == "agent")
                {
                    //caso a condição esteja ok é executado o comando goto que faz um jumper
                    //até o local definido, a tag ainda não foi criada
                    msg = "agent ok";
                    Console.WriteLine(msg);
                }
                else
                {
                    //caso não seja inserido o login ou a senha correta ele solicita que insira novamente login e senha
                    Console.Clear();
                    Console.WriteLine("Login ou senha incorreta!");

                }

                

                Console.ReadKey();
            }
        }
    }
}
