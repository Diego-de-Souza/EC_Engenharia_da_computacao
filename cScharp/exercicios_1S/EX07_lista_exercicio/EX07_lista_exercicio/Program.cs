using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07_lista_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variável
            float x, b, m;

            //solicita os dados para o usuário
            Console.Write("Digite o valor de B: ");
            b=float.Parse(Console.ReadLine());

            Console.Write("Digite o valor de M: ");
            m=float.Parse(Console.ReadLine());

            //lógica condicional que faz com que gere um erro caso o valor de M seja
            //igual a 0, caso contrário imprime o resultado
            if(m == 0)
            {
                Console.Write("Desculpe, mas não existe número que seje dividido por 0");
            }
            else
            {
                //executa o calculo
                x = b / m;

                Console.Write("B dividido por M é igual á {0}", x);
            }

            Console.ReadKey();
        }
    }
}
