using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
        /* Classe clientes criada para cadastro abstrato de uma pessoa como cliente
         * utilizado o conceito de encapsulamento, o conceito de herança vai ser aplicado em um
         * futuro desenvolvimento para dar uma dinamica diferente
         * 
         * autor: Diego de Souza
         */
    class Cliente
    {
        //nao deixando ele totalmente publico para dar controle as modificaçõpes aceitaveis
        private string nomeUsuario { get; set; }
        private string senhaUsuario { get; set; }


    }
}
