using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Barbearia
{
        /* Classe clientes criada para cadastro abstrato de uma pessoa como cliente
         * utilizado o conceito de encapsulamento, o conceito de herança vai ser aplicado em um
         * futuro desenvolvimento para dar uma dinamica diferente
         * 
         * autor: Diego de Souza
         */
    class Cliente
    {
        // Propriedades privadas com encapsulamento (usando propriedades)
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string ServicoDesejado { get; set; }
    }
}
