using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao_N2_EC2_algoritmo_2023
{
    internal class Funcionarios
    {
        public string nome;
        public string cargo;
        public int idade;
        public decimal salario;
        public decimal aumentoSalario;

        public void aumentarSalario(decimal salario, decimal aumentoSalario)
        {
            this.salario += (salario*(aumentoSalario/100))+salario;
        }

        public void alterarCargo(string novoCargo)
        {
            this.cargo = novoCargo;
        }

        public void aniversario(int niver)
        {
            this.idade = 2023 - niver;
        }

        public string mostraInformacoes()
        {
            return ("Nome do funcionário: "+this.nome + "\nIdade: "+this.idade+" anos \nCargo: "+this.cargo+"\nSalario: R$"+this.salario);
        }
    }
}
