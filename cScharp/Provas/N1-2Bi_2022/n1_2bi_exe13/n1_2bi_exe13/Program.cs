using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_2bi_exe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista de numeros para verificação e validação dos numeros digitados pelo ususario
            Int32[] listaNum = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //cria uma lista para guardar os numeros que conferem com a lista anterior
            Int32[] novaListaNum = new Int32[10];
            //criação de variável para contagem de numeros corretos
            Int32 contNum = 0;
            //Solicita ao usuário que insira a coluna de numeros a serem avaliados
            Console.WriteLine("Digite abaixo uma coluna com 10 números inteiros: ");
            //Criação da lógica condicional que compara os numeros da coluna
            for(Int32 i=1; i <=10; i++)
            {
                Console.Write($"{i}°: ");
                Int32 numDigitados = Convert.ToInt32(Console.ReadLine());
                for(Int32 num=1;num<=listaNum.Length; num++)
                {
                    if(numDigitados == listaNum[num-1]) {
                        contNum++;
                        novaListaNum[num - 1] = numDigitados;
                    }
                    
                }
            }
            //criação do laço que valida se todos os numeros estiverem certos
            if(contNum == 10)
             {
                Console.WriteLine("\nCorreto, coluna válidada!");
                for(Int32 b=0; b< novaListaNum.Length; b++)
                {
                    Console.WriteLine($"{novaListaNum[b]} *");
                }
            }
            Console.ReadKey();
        }
    }
}
