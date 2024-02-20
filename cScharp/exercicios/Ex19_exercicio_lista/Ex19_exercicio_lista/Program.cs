using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_exercicio_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solicita os dados ao usuario
            Console.Write("Digite a hora em formato de 24 horas HH:MM: ");
            string horaCompleta = Console.ReadLine();

            //Tratamento do dado recebido para verificar se está no formato correto
            Int32 horaHH = Convert.ToInt32(horaCompleta.Substring(0, 2));
            Int32 minutoMM = Convert.ToInt32(horaCompleta.Substring(3, 2));

            //laço condicional para verificar a condição e imprimir a mensagem na tela
            if(horaHH >= 0 && horaHH <= 23 && minutoMM>=0 && minutoMM <= 59)
            {
                Console.Write("Hora válida!");
            }
            else
            {
                Console.Write("Hora inválida!");
            }

            Console.ReadKey();
        }
    }
}
