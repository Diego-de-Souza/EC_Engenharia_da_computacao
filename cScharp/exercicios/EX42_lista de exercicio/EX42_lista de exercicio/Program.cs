using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX42_lista_de_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            char teste='S';
            Int64 codDetento=0;
            string nomeDetento="", condenacao="";
            Int32 pena= 0;

            while(teste == 'S') { 
            
                
                //solicita informação do usuário
                Console.Write("Digite o código do detento: ");
                while(codDetento <= 0) { 
                    codDetento = Convert.ToInt64(Console.ReadLine());
                    if(codDetento <= 0)
                        {
                            Console.Write("Código não confere, digite novamente: ");
                        }
                }
                
                Console.Write("Digite o nome do Detento: ");
                while(nomeDetento.Length < 1) { 
                    nomeDetento = Console.ReadLine();
                    if(nomeDetento.Length < 1)
                    {
                        Console.Write("Nome inválido, Digite novamente: ");
                    }
                }

                Console.Write("Digite condenação do Detento: ");
                while(condenacao.Length < 5) { 
                    condenacao = Console.ReadLine();
                    if(condenacao.Length < 5)
                    {
                        Console.Write("Desculpe, mas a condenação deve ter mais de 5 letras: ");
                    }
                }

                Console.Write("Digite a pena do Detento: ");
                while(pena <1 || pena > 500) { 
                    pena = Convert.ToInt32(Console.ReadLine());
                    if(pena <1 || pena > 500)
                    {
                        Console.Write("A pena deve ser entre 1 e 500: ");
                    }
                }

                //exibir dados
                Console.WriteLine($"\nCodigo: {codDetento} \nNome: {nomeDetento} \nCondenação: {condenacao} \npena: {pena} anos");

                while (teste != 'S' && teste != 'N') { 
                    Console.Write("\nDeseja cadastrar outro detento? (S / N): ");
                    teste = Console.ReadLine().ToUpper()[0];
                }

                /*
                    if(teste == 'S' ||)
                    {
                        teste='S';
                        codDetento=0;
                        nomeDetento="";
                        condenacao="";
                        pena=0;
                        Console.Clear();
                    }
                */
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
