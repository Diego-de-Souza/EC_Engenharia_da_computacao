using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int dia, mes, ano;
            Console.Write("Digite uma data nop formato DD/MM/AAAA: ");
            data =Console.ReadLine();

            dia = Convert.ToInt32(data.Substring(0, 2));
            mes = Convert.ToInt32(data.Substring(3, 2));
            ano = Convert.ToInt32(data.Substring(6, 4));

            if(ano >= 2000 && ano <= 2099){
                if(mes >= 1 && mes <= 12) {
                    if(dia >= 1 && dia <= 31) {
                        /*data é parcialmente correta*/
                        if( (mes == 4 || mes == 6 || mes ==9 || mes == 11) && dia == 31) {
                            Console.Write("Dia 31 para o mes é inválido");
                        }else {
                            //falta testar somente o mês de fevereiro
                            if(mes == 2 && dia > 29 && ano % 4 == 0) {
                                Console.Write("Mes Fev com mais que 29 dias");
                            }else {
                                if(mes == 2 && dia > 28 && ano % 4 != 0) {
                                    Console.Write("Mes Fev com mais que 28 dias");
                                }else {
                                    Console.Write("Data Válida!!");
                                }
                            }
                        }
                    }else {
                        Console.Write("Dia inválido");
                    }
                }else {
                    Console.Write("Mês Inválido");
                }
            }else {
                Console.Write("Ano inválido");
            }

            Console.ReadLine();
        }
    }
}
