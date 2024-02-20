using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_usuario_modelo
{
    internal class LoginUsuario
    {
        //declaração de um objeto lista para armazenamento dos logins e senhas
        public string[] listaLogin = new string[3];
        public string[] password = new string[3];
        //delcaração dos atributos para verificação de condição dos usuario e condição do laço
        public string verificacaoUsuario;
        public string controle = "true";
        //declaração de atributos para receber a senha e login digitados pelo usuario
        public string usuarioLogin { get; set; }
        public string senhaLogin { get; set; }

        //declaração do construtor que inicia a classe definindo os valores para login
        public LoginUsuario()
        {
                //declaração dos valores para cada posição na lista de login
                this.listaLogin[0] = "admin";
                this.listaLogin[1] = "user";
                this.listaLogin[2] = "agent";
                //declaração dos valores para cada posição na lista de senha
                this.password[0] = "admin123";
                this.password[1] = "user123";
                this.password[2] = "agent123";
            }
            //criação do metodo para verificação do login e senha do usuario
            public void VerificaUsuario(string login, string password)
            {
                //laço condicional para acesso ao login
                if (login == this.listaLogin[0] && password == this.password[0])
                {
                    this.verificacaoUsuario = "master";
                    this.controle = "false";
                }else if (login == this.listaLogin[1] && password == this.password[1])
                {
                    this.verificacaoUsuario = "user";
                    this.controle = "false";
                }else if (login == this.listaLogin[2] && password == this.password[2])
                {
                    this.verificacaoUsuario = "agent";
                    this.controle = "false";
                }
                else
                {
                    this.controle = "true";
                }
            }
        }
    }
