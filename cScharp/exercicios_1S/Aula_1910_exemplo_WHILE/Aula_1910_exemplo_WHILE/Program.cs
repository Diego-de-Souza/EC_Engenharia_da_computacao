using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1910_exemplo_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            cont = 1; //inicialização
            while(cont < 10) //teste de permanencia
            {
                Console.WriteLine($"Numero: {cont}");
                cont++; //incremento
            }

            //Fazendo validação
            //entrada do estado civil que aceite somente
            //C-asado, S-olteiro, V-iuvo, D-ivorciado
            char estadoCivil;

            estadoCivil = 'X';
            while(estadoCivil != 'C' && estadoCivil != 'S' && estadoCivil != 'V' && estadoCivil != 'D')
            {
                Console.Write("Digite o Estado Civil (C-S-V-D):");
                estadoCivil = Console.ReadLine().ToUpper()[0];

                if(estadoCivil != 'C' && estadoCivil != 'S' && estadoCivil != 'V' && estadoCivil != 'D')
                {
                    Console.WriteLine("Informação errada, tente novamente");
                }
            }
            Console.WriteLine("Informação Aceita..");

            switch (estadoCivil)
            {
                case 'C':
                    Console.Write("Você é casado");
                    break;
                case 'S':
                    Console.Write("Você é solteiro");
                    break;
                case 'V':
                    Console.Write("Você é viúvo");
                    break;
                case 'D':
                    Console.Write("Você é divorciado");
                    break;
            }

            Console.ReadKey();
        }
    }
}
