using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_classe
{
    internal class Carro
    {
        public string marca;
        public string modelo;
        public int ano;
        public int velocidade_atual;

        public Carro(string marca, string modelo, int ano, int velocidade_atual = 0)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidade_atual = velocidade_atual;
        }

        public void Acelerar(int incremento)
        {
            velocidade_atual += incremento;
        }

        public void Parar()
        {
            velocidade_atual = 0;
        }
    }
}
