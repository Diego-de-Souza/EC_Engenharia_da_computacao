using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_algoritmo_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando variáveis
            float t1; // intervalo de -3.402823e38 a 3.402823e38
            Single t4;//o single é um tipo de váriável especifico do dotnet, mas é igual ao float
            int t2; //intervalo de -2147483648 a 2147483647
            uint t9; // intervalo de 0 a 4294967295
            double t3; // intervalo de -1.79769313486232e308 a 1.79769313486232e307
            byte t5; // intervalo de 0 a 255
            sbyte t6; // intervalo de -128 a 127
            short t7; // intervalo de -32.768 a 32.767
            ushort t8; //intervalo de 0 a 65,535
            long t10; // intervalo -9223372036854775808 a 9223372036854775807
            ulong t11; // intervalo de 0 a 18446744073709551615
            decimal t12; // intervalo de -79228162514264337593543950335 a 79228162514264337593543950335
            char t13; //intervalo de U+0000 a U+ffff
            bool t14; //valores verdadeiro ou falso

            //para escrever algo na tela seguido pelo terminador de linha
            Console.WriteLine("escreve algo na tela");
            //lê a váriavel escrita pelo usuário que está em string e converte em single
            t1 = Convert.ToSingle(Console.ReadLine());

            //Obtém o próximo caractere ou tecla de função pressionada pelo usuário e finaliza a aplicação
            Console.ReadKey();


        }
    }
}
