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

    public partial class Form1 : Form
    {
        int idaltera;
        public object Me { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        void listaDGProduto()
        {
            conectaBanco con = new conectaBanco();
            dgProduto.DataSource = con.listaProduto();

        }

        void listaDGCategoria()
        {
            conectaBanco con = new conectaBanco();
            dgCategoria.DataSource = con.listaCategoria();
        }

        private void Sistema_Load(object sender, EventArgs e)
        {

            listaDGProduto();
            listaDGCategoria();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaDGCategoria();
        }
        void limpaCamposp()
        {
            txtNomep.Clear();
            txtDescp.Clear();
            txtPreco.Clear();
        }// fim limpa campos Produto

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            Form2 sis = new Form2();
            sis.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            produto b = new produto();
            b.Nome = txtNomealtp.Text;
            b.Descricao = txtDescaltp.Text;
            b.Preco = txtPrecoaltp.Text;
            b.IdCategoria = Convert.ToInt32(txtidCategoriaAlt.Text);
            b.IdFornecedor = Convert.ToInt32(txtidFornecedorAlt.Text);
            conectaBanco con = new conectaBanco();
            bool ret = con.alteraProduto(b, idaltera);
            if (ret == true)
            {
                MessageBox.Show("Produto alterado com sucesso!");
                listaDGProduto();
                nomeFindCat.SelectedTab = tabPage3;
            }// fim if true
            else
                MessageBox.Show(con.mensagem);

        }


        private void btn6_Click(object sender, EventArgs e)
        {
            produto b = new produto();
            b.Nome = txtNomep.Text;
            b.Descricao = txtDescp.Text;
            b.Preco = txtPreco.Text;
            b.IdFornecedor = Convert.ToInt32(txtFornProd.Text); ;
            b.IdCategoria = Convert.ToInt32(txtCatProd.Text); ;
            conectaBanco con = new conectaBanco();
            bool r = con.insereProduto(b);
            if (r == true)
            {
                MessageBox.Show("Dados inseridos com sucesso:)!");
                listaDGProduto();
                limpaCamposp();
                txtNomep.Focus(); // cursor vai para o txtnome
            }
            else
            {
                MessageBox.Show(con.mensagem);
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            (dgProduto.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("nome like '{0}%'", textBox4.Text);
        }

        private void btnremoveprod_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgProduto.Rows[linha].Cells["idProduto"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Produto", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                conectaBanco con = new conectaBanco();
                bool retorno = con.deletaProduto(id);
                if (retorno == true)
                {
                    MessageBox.Show("Produto excluido com sucesso!");
                    listaDGProduto();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            categoria b = new categoria();
            b.Nome = nomeCatins.Text;
            conectaBanco con = new conectaBanco();
            bool r = con.insereCategoria(b);
            if (r == true)
            {
                MessageBox.Show("Dados inseridos com sucesso:)!");
                listaDGCategoria();
                nomeCatins.Clear();
                nomeCatins.Focus(); // cursor vai para o txtnome
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            categoria b = new categoria();
            b.Nome = nomeAltCat.Text;
            conectaBanco con = new conectaBanco();
            bool ret = con.alteraCategoria(b, idaltera);
            if (ret == true)
            {
                MessageBox.Show("Categoria alterada com sucesso!");
                listaDGCategoria();
                nomeFindCat.SelectedTab = tabPage5;
            }// fim if true
            else
                MessageBox.Show(con.mensagem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int linha = dgCategoria.CurrentRow.Index;
            int id = Convert.ToInt32(
                    dgCategoria.Rows[linha].Cells["idCategoria"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remove Categoria", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                conectaBanco con = new conectaBanco();
                bool retorno = con.deletaCategoria(id);
                if (retorno == true)
                {
                    MessageBox.Show("Categoria excluida com sucesso!");
                    listaDGCategoria();
                }// fim if retorno true
                else
                    MessageBox.Show(con.mensagem);
            }// fim if Ok Cancela
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void txtDescp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listaDGCategoria();
            listaDGProduto();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnAlteraProduto_Click(object sender, EventArgs e)
        {
            int linha = dgProduto.CurrentRow.Index;
            idaltera = Convert.ToInt32(
                    dgProduto.Rows[linha].Cells["idProduto"].Value.ToString());
            txtNomealtp.Text = dgProduto.Rows[linha].Cells["nomeProduto"].Value.ToString();
            txtDescaltp.Text = dgProduto.Rows[linha].Cells["descricaoProduto"].Value.ToString();
            txtPrecoaltp.Text = dgProduto.Rows[linha].Cells["precoProduto"].Value.ToString();
            txtidFornecedorAlt.Text = dgProduto.Rows[linha].Cells["idFornecedor"].Value.ToString();
            nomeFindCat.SelectedTab = tabPage3;
        }

        private void btnAlteraCategoria_Click(object sender, EventArgs e)
        {
            int linha = dgCategoria.CurrentRow.Index;
            idaltera = Convert.ToInt32(
                    dgCategoria.Rows[linha].Cells["idCategoria"].Value.ToString());
            nomeAltCat.Text = dgProduto.Rows[linha].Cells["nomeCategoria"].Value.ToString();
            nomeFindCat.SelectedTab = tabPage5;
        }
    }
}
