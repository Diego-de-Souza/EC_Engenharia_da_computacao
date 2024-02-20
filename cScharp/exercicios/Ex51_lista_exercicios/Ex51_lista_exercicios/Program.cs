using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex51_lista_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomes = new string[5];
            double[] salarios = new double[5];

            //entrada de dados
            for(int pos=0; pos < nomes.Length; pos++)
            {
                Console.Write($"Digite 5 nomes ({pos + 1}): ");
                nomes[pos] = Console.ReadLine();

            }
            //entrada de dados
            for(int p=0; p < salarios.Length; p++)
            {
                Console.Write($"Digite 5 salários dos nomes anteriores({p + 1}): ");
                salarios = double.Parse(Console.ReadLine());

            }
            //exibir os dados
            for(int p=0; p <salarios.Length; p++)
            {
                Console.Write($"\n{nomes[pos]} - {salarios[p]}");
            }

            Console.ReadKey();
        }
    }
}
