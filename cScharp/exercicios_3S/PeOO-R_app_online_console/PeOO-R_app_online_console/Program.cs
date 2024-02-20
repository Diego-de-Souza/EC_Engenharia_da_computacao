using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeOO_R_app_online_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe cliente para receber os dados de login
            Cliente dadosClientes = new Cliente();
            //declaração da lista de produtos e seus dados
            Produtos[] listaProdutos = new Produtos[3];
            //criação dos produtos da lista manual
            string[] nomeProduto = new string[3] { "notebook", "televisão", "celular" };
            string[] marca = new string[3] { "Asus", "Samsung", "Asus" };
            string[] descricaoP = new string[3] { "intel Core, 8Gb RAM, 512Gb, preto", "QLed, Smart, preto", "Max pro M1, 8Gb RAM, 128Gb, azul" };
            decimal[] valorP = { 3200.00M, 5200.00M, 2800.20M };
            
            //inserindo os valores dentro do array de classe
            for(int d=0; d < listaProdutos.Length; d++)
            {
                Produtos descricaoProdutos = new Produtos(nomeProduto[d],descricaoP[d],marca[d],valorP[d]);

                listaProdutos[d] = descricaoProdutos;
            }

            //tela inicial do app online, com solicitação
            //do login e senha do usuário
            Console.WriteLine("========================== APP online PeOO-R ==========================\n\n");
            //solicitação do login do usuario
            Console.WriteLine("Digite o usuário: ");
            dadosClientes.nomeUsuario = Console.ReadLine();
            //solicitação da senha do usuario
            Console.WriteLine("Digite a senha: ");
            dadosClientes.senhaUsuario = Console.ReadLine().ToLower();

            //limpa a tela inicial e começa a exibição da segunda tela
            Console.Clear();
            Console.WriteLine("========================== APP online PeOO-R ==========================\n");
            Console.WriteLine($"cliente: {dadosClientes.nomeUsuario}\n");
            Console.WriteLine("========================== produtos ==========================\n");
            //imprime na tela a lista de produtos
            for(int i=0; i < listaProdutos.Length; i++) {
                listaProdutos[i].imprimeLista(i);
            }

            //cria uma lista para alocar os pedidos do carrinho
            int[] numeroItem = new int[3];
            //solicita o produto que será inserido no carrinho
            Console.WriteLine("Digite o numero do item que deseja colocar no carrinho: ");
            numeroItem[0] = Convert.ToInt32(Console.ReadLine());

            //cria a quantidade maxima de itens no carrinho
            int numeroItens = 1;
            //laço de confirmação de dados para carrinho
            
            for(int contagem=1;contagem <= 2; contagem++)
            {
                //solicita ao usuario para incluir o n umero de mais itens ao carrinho
                Console.WriteLine("Deseja inserir outro item no carrinho? (s/n)");
                string confirmacao = Console.ReadLine();
                //laço de confirmação que diz se vai continuar incluindo itens ou vai parar
                if(confirmacao =="s" || confirmacao == "S")
                {
                    numeroItens += 1;
                    Console.WriteLine("Ditige o numero do outro item que deseja incluir no carrinho: ");
                    numeroItem[contagem] = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Bora para o carrinho de compras!!!");
                    contagem = 2;
                }
                //acerta os numeros do indice da matriz dos produtos para os produtos nulos
                if(contagem==2 && (confirmacao =="n" || confirmacao == "N"))
                {
                    numeroItem[1]=2;
                    numeroItem[2]=1;
                }else if(contagem==3 && (confirmacao =="n" || confirmacao == "N"))
                {
                    numeroItem[1]=1;
                    numeroItem[2]=1;
                }
            }
            //envia para classe carrinho os dados dos itens para interação com carrinho de compras
            CarrinhoDeCompras carrinhoC = new CarrinhoDeCompras(numeroItem[0], numeroItem[1], numeroItem[2]);
            carrinhoC.calculoCompras(listaProdutos[(numeroItem[0]-1)].valorProduto, listaProdutos[(numeroItem[1]-1)].valorProduto, listaProdutos[(numeroItem[2]-1)].valorProduto,numeroItens);
            
            //limpa a tela para abertura do carrinho de compras
            Console.Clear();
            Console.WriteLine("========================== APP online PeOO-R ==========================\n");
            Console.WriteLine($"cliente: {dadosClientes.nomeUsuario}\n");
            Console.WriteLine("========================== Carrinho de compras ==========================\n");

            carrinhoC.itensDaNota(listaProdutos[(numeroItem[0]-1)].nomeProduto, listaProdutos[(numeroItem[1]-1)].nomeProduto, listaProdutos[(numeroItem[2]-1)].nomeProduto,numeroItens);

            Console.WriteLine("Confirma os itens selecionados? (s/n)");
            string confirmacaoCarrinho = Console.ReadLine().ToLower();
            if(confirmacaoCarrinho == "s") { 
                Console.WriteLine("Digite a senha para confirmar a compra: ");
                string senhaCompra = Console.ReadLine().ToLower();

                if(senhaCompra == dadosClientes.senhaUsuario)
                {
                    Console.Clear();
                    Console.WriteLine("========================== APP online PeOO-R ==========================\n");
                    Console.WriteLine($"cliente: {dadosClientes.nomeUsuario}\n");
                    Console.WriteLine("======================== Confirmação de compra ========================\n");
                    Console.WriteLine("Parabens, o senhor(a) acaba de adquirir excelentes itens!!!"
                                        +"Obrigado pela compra, volte sempre.");

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sentimos muito, tente novamente!");
            }
            

            Console.ReadKey();
        }
    }
}
