using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara a variavel de contagem de numeros perfeitos
            Int32 contagemNum=0;
            //criação da lista onde vai ser armazenados os numeros perfeitos
            Int32[] numerosPerfeitos = new Int32[10];
            //laço que solicita os 10 numeros a serem digitados
            for(Int32 i=0; i < 10; i++)
            {
                //declara a variavel de soma dos numeros divisores
                Int32 somaDosNumeros = 0;
                //Solicita 10 numeros inteiros positivos
                Console.Write("Digite um número: ");
                Int32 inteiroPositivos = Convert.ToInt32(Console.ReadLine());
                //Criação de um laço que roda para identificar os numeros divisiveis inteiros
                for(Int32 num=inteiroPositivos-1; num > 0; num--)
                {
                    //condição que vê por quais numeros é divivel com resto 0
                    if(inteiroPositivos%num == 0)
                    {
                        somaDosNumeros = somaDosNumeros + num;
                    }
                }
                //condição que vê quais numeros são inteiros perfeitos
                if(somaDosNumeros == inteiroPositivos)
                {
                    contagemNum++;
                    numerosPerfeitos[contagemNum] = inteiroPositivos;
                }
            }
            //laço para impressão dos dados armazenados na lista
            foreach(Int32 p in numerosPerfeitos)
            {
                if(p != 0) { 
                    Console.WriteLine($"Número perfeito: {p}");
                }
            }
            Console.ReadKey();
            
        }
    }
}
