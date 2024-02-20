using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_sistema_biblioteca_20230404
{
    internal class Livro
    {
        /// <summary>
        /// Classe livro criada para atividade de desenvolvimento de biblioteca
        /// </summary>

        //declaração de atributos
        public int Id;
        public string titulo;
        public string autor;
        public string editora;
        public string volume;
        public bool disponibilidade;

        public Livro(int Id, string nomeLivro, string nomeAutor, string nomeEditora, string volumeLivro)
        {
            this.Id = Id;
            this.titulo = nomeLivro;
            this.autor = nomeAutor;
            this.editora = nomeEditora;
            this.volume = volumeLivro;
        }



        //metodo que identifica se o livro está ou não emprestado
        public void Emprestar(string emprestimo)
        {
            if (emprestimo == "esprestado")
            {
                this.disponibilidade = true;
            }
            else
            {
                this.disponibilidade = false;
            }
        }

        //metodo que identifica de o livro está ou não devolvido
        public void Devolver(string devolucao)
        {
            if (devolucao == "devolvido")
            {
                this.disponibilidade = true;
            }
            else
            {
                this.disponibilidade = false;
            }
        }

        //metodo que chama as informações de mostra para o usuário
        public string MostrarInformacoes()
        {
            string mensagem = this.Id + ", " +
                this.titulo + ", " +
                this.autor + ", " +
                this.editora + ", " +
                this.volume + ", " +
                this.disponibilidade;

            return mensagem;
        }

    }
}

