using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            string modelo;
            Int32 ano;
            Int32 velocidade_nova;

            Console.WriteLine("Digite a marca do carro: ");
            marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro: ");
            modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a velocidade a ser acelerada: ");
            velocidade_nova= Convert.ToInt32(Console.ReadLine());

            // Cria um objeto da classe Carro e acelera em 50 km/h
            Carro carroPOO = new Carro(marca, modelo, ano);
            carroPOO.Acelerar(velocidade_nova);

            // Exibe as informações do carro antes de frear
            Console.WriteLine($"Marca: {carroPOO.marca}, Modelo: {carroPOO.modelo}, Ano: {carroPOO.ano}, Velocidade Atual: {carroPOO.velocidade_atual}");

            Console.WriteLine("Deseja frear o carro? (Y/N) ");
            string pararCarro = Convert.ToString(Console.ReadLine());

            if(pararCarro == "Y" || pararCarro == "y")
            {
                // Para o carro
                carroPOO.Parar();
            }
            

            // Exibe as informações do carro após frear
            Console.WriteLine($"Marca: {carroPOO.marca}, Modelo: {carroPOO.modelo}, Ano: {carroPOO.ano}, Velocidade Atual: {carroPOO.velocidade_atual}\n");

            // Cria um vetor de objetos da classe Carro e acelera cada um em uma velocidade diferente
            Carro[] carros = new Carro[] {
            new Carro("Chevrolet", "Onix", 2020),
            new Carro("Volkswagen", "Gol", 2015),
            new Carro("Ford", "Fiesta", 2012)
        };

            for (int i = 0; i < carros.Length; i++)
            {
                int velocidade = (i + 1) * 20; // Acelera em 20 km/h, 40 km/h, 60 km/h...
                carros[i].Acelerar(velocidade);
                Console.WriteLine($"Marca: {carros[i].marca}, Modelo: {carros[i].modelo}, Ano: {carros[i].ano}, Velocidade Atual: {carros[i].velocidade_atual}");
            }

            Console.ReadKey();
        }

        
    }
}
