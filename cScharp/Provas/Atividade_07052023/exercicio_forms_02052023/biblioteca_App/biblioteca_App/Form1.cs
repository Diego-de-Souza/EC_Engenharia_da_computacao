using System;
using System.Windows.Forms;

namespace biblioteca_App
{
    public partial class Form1 : Form
    {

        //declaração da classe como objeto
        LoginUsuario identificacaoUser = new LoginUsuario();
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            identificacaoUser.usuarioLogin = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            identificacaoUser.senhaLogin = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            identificacaoUser.VerificaUsuario(textBox1.Text, textBox2.Text);
            if (string.IsNullOrEmpty(identificacaoUser.usuarioLogin) || string.IsNullOrEmpty(identificacaoUser.senhaLogin))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            if (identificacaoUser.verificacaoUsuario == "master")
            {
                MessageBox.Show("Login Master successful!");
                // Abrir a nova janela do aplicativo
                form2.Show();
                return;
            }
            else if (identificacaoUser.verificacaoUsuario == "user")
            {
                MessageBox.Show("Login User successful!");
                // Abrir a nova janela do aplicativo
                form3.Show();
                return;
            }
            else if (identificacaoUser.verificacaoUsuario == "agent")
            {
                MessageBox.Show("Login successful!");
                // Abrir a nova janela do aplicativo
                Form2 form2 = new Form2();
                return;
            }
            else
            {
                MessageBox.Show("Usuario incorreto!!!");
            }


        }
    }
}
