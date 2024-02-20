using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cadastro cadastro = new Cadastro(253, "Emilly", "Lorraine","emillylorrane.souza@gmail.com", 10,408506504-33);

            Calculadora calc = new Calculadora();
            calc.inserirDados();
            calc.somar();
            calc.mostraResultado();

            Console.WriteLine("\n\nResponsavel pela calculadora "+
                cadastro.cod+
                " \nNome: "+cadastro.nome+
                " "+cadastro.sobreNome+
                " \nE-mail: "+cadastro.eMail+
                " \nIdade: "+cadastro.idade+
                " \nCPF: "+cadastro.cPF);

            Console.ReadKey();
        }
    }
}
