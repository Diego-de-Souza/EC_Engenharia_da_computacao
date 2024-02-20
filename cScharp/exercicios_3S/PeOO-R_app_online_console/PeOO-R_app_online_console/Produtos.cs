using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
        /* Classe Produtos uma abstraçãode um produto ou serviço oferecido
         * utilizado o conceito de encapsulamento, o conceito de herança vai ser aplicado em um
         * futuro desenvolvimento para dar uma dinamica diferente
         * 
         * autor: Diego de Souza
         */
    class Produtos
    {
        private string nomeProduto { get; set; }
        private decimal valorProduto { get; set; }
        private string descricao { get; set; }
        private string marca { get; set; }

        public Produtos(string nomeProduto,  string descricao, string marca, decimal valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
            this.descricao = descricao;
            this.marca = marca;
        }

        public void imprimeLista(int numeroitem)
        {
            Console.WriteLine($"Item:{numeroitem} - Produto: " + this.nomeProduto
                                  + "/ Descrição: " + this.descricao
                                  + "/ Marca: " + this.marca
                                  + "/ valor: " + this.valorProduto + "\n");
        }
    }
}
