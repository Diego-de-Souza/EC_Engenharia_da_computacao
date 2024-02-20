using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class Cadastro
    {
        public Int32 cod;
        public string nome;
        public string sobreNome;
        public string eMail;
        public Int16 idade;
        public double cPF;


        public Cadastro( Int32 cod, string nome, string sobreNome, string eMail, Int16 idade, double cPF)
        {
            this.cod = cod;
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.eMail = eMail; 
            this.idade = idade;
            this.cPF = cPF;
        }

        public void nomeCompleto(){
           string nomeFUll = this.nome + ' ' + this.sobreNome;
        }
    }
}
