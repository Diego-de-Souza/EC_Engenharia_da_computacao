using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_algoritmo_EC2
{
    public partial class Form1 : Form
    {
        Livros cadastroLivros = new Livros();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cadastroLivros.nomeLivro = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            cadastroLivros.nomeAutor = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            cadastroLivros.genero = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            cadastroLivros.editora = textBox4.Text;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            cadastroLivros.volume = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cadastroLivros.nomeLivro) || string.IsNullOrEmpty(cadastroLivros.nomeAutor)||string.IsNullOrEmpty(cadastroLivros.genero)||string.IsNullOrEmpty(cadastroLivros.editora)||string.IsNullOrEmpty(cadastroLivros.volume))
            {
                MessageBox.Show("Por gentileza digite todas as informações!!!");
                return;
            }
            if (cadastroLivros.quantCadastro == 5) { 
            MessageBox.Show(cadastroLivros.cadastrado);
            MessageBox.Show("nome do Livro: " + cadastroLivros.nomeLivro + "\n" + "nome do Autor: " + cadastroLivros.nomeAutor + "\n" + "gênero do livro: " + cadastroLivros.genero + "\n" +
                "noma da Editora: " + cadastroLivros.editora + "\n" + "volume: " + cadastroLivros.volume+"\n"+ cadastroLivros.cadastrado);
            }
        }

        
    }
}
