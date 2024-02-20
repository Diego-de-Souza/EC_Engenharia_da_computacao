using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Atividade_algoritmo_II_N1
{
    internal class Program
    {
        static double f1(double x)
        {
            return x * x * x * -2 * x * x + 8;
        }

        static double f2(double y)
        {
            return Math.Cos(3 * y);
        }

        static double f3(double z)
        {
            return Math.Exp(2 * z);
        }

        static void Main(string[] args)
        {
            double a = 0.0; //limite inferior de integração
            double b = 1.0; // limite superior de integração
            int N = 1000;  //numero de subintervalos
            double h = (b - a) / N; //tamanho do subintervalo
            double S = 0.5 * (f1(a) + f1(b)); //soma inicial (primeiro e ultimo termo)
            double S2 = 0.5* (f2(a) + f2(b)); //soma inicial (primeiro e ultimo termo)
            double S3 = f3(a) + f3(b); //soma inicial (primeiro e ultimo termo

            for(int i1= 0; i1 < N; i1++)
            {
                double x_i = a + i1 * h;
                S += f1(x_i);
            }

            for(int i2=0; i2 < N; i2++)
            {
                double y_2 = a + i2 * h;
                S += f2(y_2);
            }

            for (int i3=0;i3 < N; i3++)
            {
                double z_i = a+i3 * h;
                double z_i_1 = a + (i3 + 1) * h;
                double z_i_2 = a +(i3+2) * h;
                S3 += 4 * f3(z_i_1) + 2 * f3(z_i_2);
            }

            double resultado1 = h * S; //resultado final da primeira integral
            double resultado2 = h * S2; //resultado final da segunda integral
            double resultado3 = (b - a) / 6 * N; //resultado final da terceira integral

            Console.WriteLine("O resultado da integral f(x)=x³-2x²+8 com intervalo entre [0,1] é: " + resultado1);
            Console.WriteLine("O resultado da integral f(x)=cos(3x) com intervalo entre [0,1] é: " + resultado2);
            Console.WriteLine("O resultado da integral f(x)=e²x com intervalo entre [0,1] é: " + resultado3);


            Console.ReadKey();
        }
    }
}
