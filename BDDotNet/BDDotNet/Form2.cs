using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace BDDotNet
{
    public partial class Form2 : Form
    {
        int idalterafor;
        public Form2()
        {
            InitializeComponent();
        }
        void listaDGFornecedor()
        {
            conectaBanco con = new conectaBanco();
            dgFornecedor.DataSource = con.listaFornecedor();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listaDGFornecedor();
        }
        void limpaCamposp()
        {
            textBox1.Clear();
            textBox2.Clear();
        }// fim limpa campos Produto
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Form1 sis = new Form1();
            sis.Show();
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fornecedor b = new fornecedor();
            b.Nome = textBox1.Text;
            b.Cnpj = Convert.ToInt32(textBox2.Text);
            conectaBanco con = new conectaBanco();
            bool r = con.insereFornecedor(b);
            if (r == true)
            {
                MessageBox.Show("Dados inseridos com sucesso:)!");
                listaDGFornecedor();
                limpaCamposp();
                textBox1.Focus(); // cursor vai para o txtnome
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgFornecedor.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("nome like '{0}%'", textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int linha = dgFornecedor.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgFornecedor.Rows[linha].Cells["idFornecedor"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Fornecedor", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                conectaBanco con = new conectaBanco();
                bool retorno = con.deletaFornecedor(id);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluido com sucesso!");
                    listaDGFornecedor();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fornecedor b = new fornecedor();
            b.Nome = textBox5.Text;
            b.Cnpj = Convert.ToInt32(textBox4.Text);
            conectaBanco con = new conectaBanco();
            bool ret = con.alteraFornecedor(b, idalterafor);
            if (ret == true)
            {
                MessageBox.Show("Fornecedor alterado com sucesso!");
                listaDGFornecedor();
                tabControl1.SelectedTab = tab2;
            }// fim if true
            else
                MessageBox.Show(con.mensagem);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            listaDGFornecedor();
        }
    }
}