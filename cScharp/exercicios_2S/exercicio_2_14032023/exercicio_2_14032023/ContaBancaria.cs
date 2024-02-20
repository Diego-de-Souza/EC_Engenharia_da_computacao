using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2_14032023
{
    internal class ContaBancaria
    {
        public string nomeTitular;
        public int numeroConta;
        public double saldo=0;          
        public bool statusOperacao=true;

        public ContaBancaria(string nome, int numero)
        {
            this.nomeTitular = nome;
            this.numeroConta = numero;
        }

        public void depositar(double deposito)
        {
            this.saldo = deposito;
        }

        public void Sacar(int retirada)
        {
            if(retirada < this.saldo)
            {
                this.saldo = this.saldo - retirada;
                this.statusOperacao = true;
            }else if (retirada > this.saldo)
            {
                this.statusOperacao = false;
            }
        }
    }
}
