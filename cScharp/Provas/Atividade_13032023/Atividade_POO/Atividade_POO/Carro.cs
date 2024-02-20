using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO
{
    class Carro
    {
        string marca { get; set; }
        string modelo { get; set; }
        int ano { get; set; }
        int velocidadeAtual=0 ;

        public Carro(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public void acelerar( int vel)
        {
            velocidadeAtual = vel + velocidadeAtual;
        }

        public void pararCarro(string stopCar)
        {
            if(stopCar == "p" || stopCar == "P")
            {
                velocidadeAtual = 0;
            }
        }
    }
}
