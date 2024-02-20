using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_2bi_exe05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara dado do laço
            char saiLaco1 = 'N', saiLaco2 = 'N';
            double n1, n2, escolha;
            Int16 terminaLaco = 1, invalido = 1;
            while (terminaLaco == 1)
            {
                do
                {
                    //solicita os dados da n1
                    Console.Write("Digite a nota da 1° prova: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    if (n1 < 0.0 || n1 > 10.0)
                    {
                        Console.Write("Valor inválido, tente novamente. ");
                    }
                    else
                    {
                        saiLaco1 = 'S';
                    }
                } while (saiLaco1 == 'N');
                do
                {
                    //solicita os dados da n1
                    Console.Write("Digite a nota da 2° prova: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    if (n2 < 0.0 || n2 > 10.0)
                    {
                        Console.Write("Valor inválido, por favor digite novamente: ");
                    }
                    else
                    {
                        saiLaco2 = 'S';
                    }
                } while (saiLaco2 == 'N');
                //calcula a media
                double result = (n1 + n2) / 2;
                //imprime a media na tela
                Console.WriteLine($"Sua média semestral é {result}");
                //imprime a mensagem para sair do laço
                Console.Write("Novo Calculo? Digite 1 para sim e 2 para não: ");

                do
                {
                    escolha = Convert.ToDouble(Console.ReadLine());
                    if (escolha != 2)
                    {
                        if (escolha != 1)
                        {
                            Console.Write("Valor digitado é inválido!");

                        }
                        else
                        {

                            invalido = 2;
                        }
                    }
                    else
                    {
                        terminaLaco = 2;
                    }
                } while (invalido == 1);
            }
            Console.ReadLine();

        }
    }
}
