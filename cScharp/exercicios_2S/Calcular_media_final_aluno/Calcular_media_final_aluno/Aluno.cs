using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_media_final_aluno
{
    internal class Aluno
    {
        public string nome;
        public int idade;
        public double mediaFinal;
        public string aprovacao;

        public Aluno(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void calcularMediaFinal(double media1, double media2)
        {
            this.mediaFinal = (media1 + media2) / 2;
        }

        public void Aprovar()
        {
            if(this.mediaFinal >= 7)
            {
                this.aprovacao = "Aprovado";
            }else
            {
                this.aprovacao = "Reprovado";
            }
        }

        Publisher string dados()
        {
            return this.nome + this.idade + this.mediaFinal + this.aprovacao;
        }

    }
}
