using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_sistema_biblioteca
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
        public bool disponibilidade=true;

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
            if (emprestimo == "s")
            {
                this.disponibilidade = false;
            }
            else
            {
                this.disponibilidade = true;
            }
        }

        //metodo que identifica de o livro está ou não devolvido
        public void Devolver(string devolucao)
        {
            if (devolucao == "s")
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
            string mensagem = "ID: "+this.Id + ", Titulo: " +
                this.titulo + ", Autor: " +
                this.autor + ", Editora: " +
                this.editora + ", Volume: " +
                this.volume + ",  Disponivel: " +
                this.disponibilidade;

            return mensagem;
        }

    }
}
