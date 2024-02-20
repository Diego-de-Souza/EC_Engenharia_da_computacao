using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
        /* Classe Carrinho de compras uma abstraçao de um carrinho de compras
         * utilizado o conceito de encapsulamento, o conceito de herança vai ser aplicado em um
         * futuro desenvolvimento para dar uma dinamica diferente
         * 
         * autor: Diego de Souza
         */
    class CarrinhoDeCompras
    {
        //declarando as variaveis de forma privada no conceito de encapsulamento
        //para ter um controle ao o que quero que meu usuario veja e possa modificar
        private int item1;
        private int item2;
        private int item3;
        private decimal valorItem1;
        private decimal valorItem2;
        private decimal valorItem3;
        private decimal totalCarrinho;

        public CarrinhoDeCompras(int item1, int item2, int item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public void calculoCompras(decimal valor1, decimal valor2, decimal valor3, int qtdItens)
        {
            if(qtdItens == 3)
            {
                this.totalCarrinho = valor1 + valor2 + valor3;
            }else if (qtdItens == 2)
            {
                this.totalCarrinho = valor1 + valor2;
            }else if(qtdItens == 1)
            {
                this.totalCarrinho = valor1;
            }
            this.valorItem1 = valor1;
            this.valorItem2 = valor2;
            this.valorItem3 = valor3;
        }

        public void itensDaNota(string produtonota1, string produtonota2, string produtonota3, int qtdItens)
        {
            if (qtdItens == 3)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"item2: {this.valorItem2} - {produtonota2}");
                Console.WriteLine($"item3: {this.valorItem2} - {produtonota3}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
            else if (qtdItens == 2)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"item2: {this.valorItem2} - {produtonota2}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
            else if (qtdItens == 1)
            {
                Console.WriteLine($"item1: {this.valorItem1} - {produtonota1}");
                Console.WriteLine($"Total: {this.totalCarrinho}");
            }
        }
    }
}
