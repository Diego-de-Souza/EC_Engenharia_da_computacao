using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca_App
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Volta para tela de login");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limpa os dados e começa um novo cadastro");
        }
    }
}
