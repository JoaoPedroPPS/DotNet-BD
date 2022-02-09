using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDDotNet
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            



        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "adm" && maskedTextBox2.Text == "1234")
            {
                Form2 sis2 = new Form2();
                Form1 sis = new Form1();
   
                sis2.Show();
                sis.Show();
               
            }// fim if
            else
                MessageBox.Show("Chave de acesso incorreta!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
