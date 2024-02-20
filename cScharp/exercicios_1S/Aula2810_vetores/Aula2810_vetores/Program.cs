using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2810_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*em vetores deve ser declarado na criação o tamanho do vetor, não se pode criar um vetor sem tamanho,
              vetor sem tamanho seria considerado uma operação dinamica e isso não tem em Csharp
            EXE: String[] vetor = new string[5]
            
             */
            //cria um vetor de 5 string
            String[] nomes = new string[5];
            //cria um vetor de 3 inteiros
            Int32[] numeros = new Int32[3];
            //cria um vetor de 2 doubles(salario) e ja coloca valor
            double[] salarios = { 1590.99, 3400.00 };

            //para atribuir um dado fixo
            nomes[0] = "João";

            //para atribuir um dado do usuario
            numeros[2] = Convert.ToInt32(Console.ReadLine());

            int pos = 2;
            nomes[pos] = Console.ReadLine();

            //entrada de dados automática
            for(int p = 0; p < nomes.Length; p++)
            {
                Console.Write($"Digite o Nome[{p + 1}]: ");
                nomes[p] = Console.ReadLine();
            }

            //não funciona para exibir os dados de nomes
            Console.Write(nomes);
            Console.Write(nomes[]);

            //para exibir todos os nomes
            for(int p=0; p<nomes.Length; p++)
            {
                Console.WriteLine($"Nomes [{p+1}]")
            }

            //outra forma
            foreach(String p in nomes)
            {
                Console.WriteLine($"Nomes: {p}");
            }
        }
    }
}
