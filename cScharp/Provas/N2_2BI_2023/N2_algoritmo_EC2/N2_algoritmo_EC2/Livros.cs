using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_algoritmo_EC2
{
    internal class Livros
    {
        //criação das váriaveis
        public string nomeLivro { get; set; }
        public string nomeAutor { get; set; }
        public string genero { get; set; }
        public string editora { get; set; }
        public string volume { get; set; }
        public string cadastrado { get; set; }
        public int quantCadastro=0;
        public int[] stringOK = new int[5];


        //criação do método que concatena os dados e retorna em uma variavel
        public void CadatroOk()
        {
            //confirmando que todos os dados são uma string
            if (this.nomeLivro.GetType() == typeof(string)) 
            {
                this.stringOK[0] = 1;
            }
            if(this.nomeAutor.GetType() == typeof(string)) 
            {
                this.stringOK[1] = 1;
            }
            if(this.volume.GetType() == typeof(string))
            {
                this.stringOK[2]= 1;
            }
            if (this.volume.GetType() == typeof(string))
            {
                this.stringOK[3] = 1;
            }
            if (this.volume.GetType() == typeof(string))
            {
                this.stringOK[4] = 1;
            }
            //varendo a string para soam e verificação de retorno
            for(int i = 0; i < stringOK.Length; i++)
            {
                this.quantCadastro += stringOK[i];
            }
            //condição de retorno
            if(quantCadastro == 5)
            {
                cadastrado = "cadastrado com sucesso!";
            }
            else
            {
                cadastrado = "Divergente";
            }
        }
    }
}
