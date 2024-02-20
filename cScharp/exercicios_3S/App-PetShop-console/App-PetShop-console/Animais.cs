using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_PetShop_console
{
    public class Animais
    {
        //declaração dos atributos
        public string Nome;
        public Int16 Especie;
        public DateTime DataNasc;
        private float Peso;
        


        //criação dos métodos
        //metodo de cadastro dos animais
        public void Cadastrar()
        {
            bool tipoEspecie = false;
            Console.WriteLine("Inserir nome do animal: ");
            this.Nome = Console.ReadLine();
            //laço para especificar especie de animal e tratamento de erro caso digitado errado
            while(tipoEspecie == false) { 
                Console.WriteLine("Inserir o numero da especie do animal: "+
                                    "\n 1 - Mamifero"+
                                    "\n 2 - Ave"+
                                    "\n 3 - Inseto");
                this.Especie = Int16.Parse(Console.ReadLine());
                if(this.Especie == 1 || this.Especie == 2 || this.Especie == 3) { 
                    tipoEspecie = true;
                }
                else
                {
                    Console.WriteLine("O tipo de especie escolhido não existe! Escolha novamente.");
                }
            }

            Console.WriteLine("Inserir a data de nascimento do animal: exe(01/01/1900) ");
            this.DataNasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Inserir o peso do animal: ");
            this.Peso = float.Parse(Console.ReadLine());
        }
        //metodo que exclui os dados dos animais
        public void Excluir()
        {
            this.Nome = null;
            this.Especie = 0;
            this.DataNasc = DateTime.MinValue;
            this.Peso = 0;
            //Método para excluir os dados do animal
        }
        
        public void Alterar() { 
            //Método para alterar dados no animal
            Console.WriteLine("---> Alteração de Cadastro do Animal <---");
            Console.Write("Nome: ");
            this.Nome = Console.ReadLine();

            Console.Write("Digite a espécie: "+
                            "\n 1 - Mamifero"+
                            "\n 2 - Ave"+
                            "\n 3 - Inseto");
            this.Especie = Int16.Parse(Console.ReadLine());

            Console.Write("Digite a data de nascimento. \n Formato: dd/mm/aaaa");
            this.DataNasc = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o peso: ");
            this.Peso = float.Parse(Console.ReadLine());
        }
        //metodo de consulta de dados do animal
        public void Consultar()
        {
            //método para consulta os dados
            Console.WriteLine("---> Consultar dados do animal <---");

            do
            {
                Console.WriteLine("Informe o nome do animal para consultar dados: ");
                string consultaAnimal = Console.ReadLine().ToUpper();

                if (consultaAnimal == Nome.ToUpper())
                {
                    Console.WriteLine("Dados encontrados:");
                    Console.WriteLine("Nome: " + this.Nome);
                    Console.WriteLine("Data de Nascimento: " + this.DataNasc);
                    Console.WriteLine($"Espécie: {this.Especie}");
                    Console.WriteLine("Peso: " + this.Peso);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Nenhum animal cadastrado.");
                }
            }while(true);
        }
    }

    class Servicos : Animais
    {
        Animais atributosAnimais = new Animais();
        public Boolean ServicosCompletos=false;
        public int Dias;
        public int TipoDeHospedagem;
        public string EnderecoRetirada;
        public string EnderecoEntrega;
        public string Dieta;

        public void ServicosVeterinarios(Int16 especie)
        {
            Console.WriteLine("Deseja os serviços vegetarianos para seu animal? (s/n)");
            string aceite = Console.ReadLine().ToUpper();
            if(aceite == "S")
            {
                if(especie == 1)
                {
                    Dieta = "Á base de legumes";
                }else if(especie == 2)
                {
                    Dieta = "Á base de sementes";
                }else if(especie == 3)
                {
                    Dieta = "Á base microorganismos vegetais";
                }
            }
            else
            {
               Dieta = "Livre";
            }
        }

        public void Taxi()
        {
            Console.WriteLine("Digite o nome da Rua onde o animal deve ser retirado:");
            string ruaDelivery = Console.ReadLine();
            Console.WriteLine("Digite o número do endereço: ");
            string numDelivery = Console.ReadLine();
            Console.WriteLine("Digite o nome do Bairro: ");
            string bairroDelivery = Console.ReadLine();
            Console.WriteLine("Digite a o nome da cidade: ");
            string cidadeDelivery = Console.ReadLine();
            Console.WriteLine("Digite o número do CEP: Exe(000000-000)");
            string cepDelivery = Console.ReadLine();
            EnderecoRetirada = ruaDelivery+", "+numDelivery+" - "+bairroDelivery+" - "+cidadeDelivery+" - "+cepDelivery;
        }

        public void Hospedagem(string nomeDoAnimal )
        {
            Console.WriteLine("Qual a quantidade de dias o animal vai ficar hospedado? ");
            Dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual tipo de Quarto deseja hospedar seu animal: "+
                                "\n 1 - Simples"+
                                "\n 2 - Executivo"+
                                "\n 3 - Luxo");
            TipoDeHospedagem = int.Parse(Console.ReadLine());

        }

        public void Delivery()
        {
            Console.WriteLine("Digite o nome da Rua onde o animal deve ser retirado:");
            string ruaDelivery = Console.ReadLine();
            Console.WriteLine("Digite o número do endereço: ");
            string numDelivery = Console.ReadLine();
            Console.WriteLine("Digite o nome do Bairro: ");
            string bairroDelivery = Console.ReadLine();
            Console.WriteLine("Digite a o nome da cidade: ");
            string cidadeDelivery = Console.ReadLine();
            Console.WriteLine("Digite o número do CEP: Exe(000000-000)");
            string cepDelivery = Console.ReadLine();
            EnderecoEntrega = ruaDelivery+", "+numDelivery+" - "+bairroDelivery+" - "+cidadeDelivery+" - "+cepDelivery;
        }

    }

    class Mamiferos : Servicos
    {
        public Boolean Pentear=false;
        public Boolean ApararUnhas=false;
        public string TipoShampoo;
        public string Aderecos;
        public string AlimentacaoMamifero;
        public string TipoAnimal;
        public string Raca;

        public void BanhoETosa()
        {
            bool fimLaco=false;

            Console.WriteLine("Qual tipo de shampoo: "+
                                "\n 1 - Cachorro"+
                                "\n 2 - Gato"+
                                "\n 3 - Ramister"+
                                "\n 4 - Peixe");
            TipoShampoo = Console.ReadLine();
            while (fimLaco==false)
            {
                Console.WriteLine("Qual adereço deseja inserir no animal após o banho e tosa: "+
                                "\n 1 - Laço"+
                                "\n 2 - Gravata"+
                                "\n 3 - Adesivos");
                Int16 tipoAdereco = Int16.Parse(Console.ReadLine());
                if(tipoAdereco == 1)
                {
                    Aderecos = "Colocar Laço";
                    fimLaco = true;
                }else if(tipoAdereco == 2)
                {
                    Aderecos = "Colocar Gravata";
                    fimLaco = true;
                }else if(tipoAdereco == 3)
                {
                    Aderecos = "Colocar adesivos";
                    fimLaco = true;
                }
                else
                {
                    Console.WriteLine("Tipo de adereço não confere, digite o numero correto! ");
                }
            }
            Console.WriteLine("Deseja aparar as unhas? (s/n)");
            string opcaoUnhas = Console.ReadLine().ToLower();
            if(opcaoUnhas == "s")
            {
                ApararUnhas = true;
            }
            else
            {
                ApararUnhas = false;
            }
            Console.WriteLine("Deseja fazer escova em seu animal? (s/n)");
            string opcaoEscova = Console.ReadLine().ToLower();
            if(opcaoEscova == "s")
            {
                Pentear = true;
            }else
            {
                Pentear = false;
            }
        }

        public void DadosManifero()
        {
            Console.WriteLine("Qual tipo do animal: ");
            TipoAnimal = Console.ReadLine();
            Console.WriteLine("Qual a raça do animal: ");
            Raca = Console.ReadLine();
        }
    }

    class Aves : Servicos
    {
        public string Pelagem;
        public string Asas;
        public string TipoBico;
        public string AlimentacaoAve;
        public string TipoAve;

        public void BanhoAve()
        {
            Console.WriteLine("Deseja fazer higienização de Bico? (s/n) ");
            string opcaoBico = Console.ReadLine().ToLower();
            if(opcaoBico == "s")
            {
                TipoBico = "Limpeza de Bico especial";
            }else
            {
                TipoBico = "Limpeza de bico simples";
            }
            
        }

        public void DadosAve()
        {
            Console.WriteLine("Qual o tipo do animal: ");
            TipoAve = Console.ReadLine();
        }
    }

    class Insetos : Servicos
    {
        public string TipoDeInseto;
        public string AlimentacaoInseto;

    }
}
