using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            double maiorAltura = 0, menorAltura = 10.0, alturaFem = 0, mediaAlturaFem ;
            Int32 sexoFem = 0, quantHom ;
            for(int i=0; i < 10; i++)
            {
                Console.Write("Por favor, digite sua altura: ");
                double alturaUsuario = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite seu sexo (M-Masculino / F-Feminina): ");
                char sexo = Console.ReadLine().ToUpper()[0];
                if(alturaUsuario > maiorAltura)
                {
                    maiorAltura = alturaUsuario;
                }
                if(alturaUsuario < menorAltura)
                {
                    menorAltura = alturaUsuario;
                }
                if(sexo == 'F')
                {
                    sexoFem++;
                    alturaFem = alturaFem + alturaUsuario;
                }

            }
            //calculo da média de altura das mulheres
            mediaAlturaFem = alturaFem / sexoFem;
            //soma dos homens
            quantHom = 10 - sexoFem;
            //escreve na tela o resultado
            Console.Write("Das 10 pessoas cadastradas a maior altura é {0:0.00}, a menor é {1:0.00}\na média da altura das mulher é {2:0.00} e a quantidade de homens é {3}", maiorAltura, menorAltura, mediaAlturaFem, quantHom);
            Console.ReadKey();
        }
    }
}
