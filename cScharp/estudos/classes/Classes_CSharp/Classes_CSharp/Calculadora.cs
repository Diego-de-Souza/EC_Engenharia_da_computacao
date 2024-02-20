using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    internal class Calculadora
    {
        public int valor1;
        public int valor2;
        public int total;

        public void inserirDados()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor valor: ");
            valor2 = int.Parse(Console.ReadLine());
        }

        public void mostraResultado()
        {
            Console.WriteLine("O total da operação é: " + total);
        }

        public void somar()
        {
            total = valor1 + valor2;
        }
        public void subtrair()
        {
            total = valor1 - valor2;
        }
        public void dividir()
        {
            total = valor1 / valor2;
        }
        public void multiplicar()
        {
            total = valor1 * valor2;
        }
    }
}
