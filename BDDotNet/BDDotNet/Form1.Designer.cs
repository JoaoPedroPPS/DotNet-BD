
namespace BDDotNet
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nomeFindCat = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtCatProd = new System.Windows.Forms.TextBox();
            this.txtFornProd = new System.Windows.Forms.TextBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnremoveprod = new System.Windows.Forms.Button();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrecoaltp = new System.Windows.Forms.TextBox();
            this.txtDescaltp = new System.Windows.Forms.TextBox();
            this.txtNomealtp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.nomeCatins = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.nomeAltCat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtidFornecedorAlt = new System.Windows.Forms.TextBox();
            this.txtidCategoriaAlt = new System.Windows.Forms.TextBox();
            this.txtIdProdutoAlt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAlteraProduto = new System.Windows.Forms.Button();
            this.btnAlteraCategoria = new System.Windows.Forms.Button();
            this.nomeFindCat.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeFindCat
            // 
            this.nomeFindCat.Controls.Add(this.TabPage1);
            this.nomeFindCat.Controls.Add(this.tabPage2);
            this.nomeFindCat.Controls.Add(this.tabPage3);
            this.nomeFindCat.Controls.Add(this.tabPage4);
            this.nomeFindCat.Controls.Add(this.tabPage5);
            this.nomeFindCat.Controls.Add(this.tabPage6);
            this.nomeFindCat.Location = new System.Drawing.Point(162, 127);
            this.nomeFindCat.Name = "nomeFindCat";
            this.nomeFindCat.SelectedIndex = 0;
            this.nomeFindCat.Size = new System.Drawing.Size(626, 311);
            this.nomeFindCat.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Silver;
            this.TabPage1.Controls.Add(this.txtCatProd);
            this.TabPage1.Controls.Add(this.txtFornProd);
            this.TabPage1.Controls.Add(this.btn6);
            this.TabPage1.Controls.Add(this.label5);
            this.TabPage1.Controls.Add(this.label4);
            this.TabPage1.Controls.Add(this.txtPreco);
            this.TabPage1.Controls.Add(this.txtDescp);
            this.TabPage1.Controls.Add(this.label3);
            this.TabPage1.Controls.Add(this.label2);
            this.TabPage1.Controls.Add(this.txtNomep);
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(618, 285);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Cadastrar Produto";
            this.TabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtCatProd
            // 
            this.txtCatProd.Location = new System.Drawing.Point(133, 184);
            this.txtCatProd.Name = "txtCatProd";
            this.txtCatProd.Size = new System.Drawing.Size(427, 20);
            this.txtCatProd.TabIndex = 14;
            // 
            // txtFornProd
            // 
            this.txtFornProd.Location = new System.Drawing.Point(133, 140);
            this.txtFornProd.Name = "txtFornProd";
            this.txtFornProd.Size = new System.Drawing.Size(427, 20);
            this.txtFornProd.TabIndex = 13;
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(286, 241);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "Confirmar";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fornecedor:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(133, 96);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(427, 20);
            this.txtPreco.TabIndex = 8;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtDescp
            // 
            this.txtDescp.Location = new System.Drawing.Point(133, 53);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(427, 20);
            this.txtDescp.TabIndex = 7;
            this.txtDescp.TextChanged += new System.EventHandler(this.txtDescp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição:";
            // 
            // txtNomep
            // 
            this.txtNomep.Location = new System.Drawing.Point(133, 14);
            this.txtNomep.Name = "txtNomep";
            this.txtNomep.Size = new System.Drawing.Size(427, 20);
            this.txtNomep.TabIndex = 3;
            this.txtNomep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.btnAlteraProduto);
            this.tabPage2.Controls.Add(this.btnremoveprod);
            this.tabPage2.Controls.Add(this.dgProduto);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Produto";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnremoveprod
            // 
            this.btnremoveprod.BackColor = System.Drawing.Color.Silver;
            this.btnremoveprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveprod.Location = new System.Drawing.Point(537, 12);
            this.btnremoveprod.Name = "btnremoveprod";
            this.btnremoveprod.Size = new System.Drawing.Size(75, 23);
            this.btnremoveprod.TabIndex = 6;
            this.btnremoveprod.Text = "Remover";
            this.btnremoveprod.UseVisualStyleBackColor = false;
            this.btnremoveprod.Click += new System.EventHandler(this.btnremoveprod_Click);
            // 
            // dgProduto
            // 
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(10, 44);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.Size = new System.Drawing.Size(602, 228);
            this.dgProduto.TabIndex = 5;
            this.dgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellContentClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(89, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtIdProdutoAlt);
            this.tabPage3.Controls.Add(this.txtidCategoriaAlt);
            this.tabPage3.Controls.Add(this.txtidFornecedorAlt);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.txtPrecoaltp);
            this.tabPage3.Controls.Add(this.txtDescaltp);
            this.tabPage3.Controls.Add(this.txtNomealtp);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 285);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alterar Produto";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(224, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "Confirmar Alteração";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPrecoaltp
            // 
            this.txtPrecoaltp.Location = new System.Drawing.Point(130, 105);
            this.txtPrecoaltp.Name = "txtPrecoaltp";
            this.txtPrecoaltp.Size = new System.Drawing.Size(427, 20);
            this.txtPrecoaltp.TabIndex = 14;
            // 
            // txtDescaltp
            // 
            this.txtDescaltp.Location = new System.Drawing.Point(130, 66);
            this.txtDescaltp.Name = "txtDescaltp";
            this.txtDescaltp.Size = new System.Drawing.Size(427, 20);
            this.txtDescaltp.TabIndex = 13;
            // 
            // txtNomealtp
            // 
            this.txtNomealtp.Location = new System.Drawing.Point(130, 28);
            this.txtNomealtp.Name = "txtNomealtp";
            this.txtNomealtp.Size = new System.Drawing.Size(427, 20);
            this.txtNomealtp.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Categoria:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Fornecedor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Preço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.nomeCatins);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(618, 285);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastrar Categoria";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(524, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Confirmar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // nomeCatins
            // 
            this.nomeCatins.Location = new System.Drawing.Point(81, 18);
            this.nomeCatins.Name = "nomeCatins";
            this.nomeCatins.Size = new System.Drawing.Size(427, 20);
            this.nomeCatins.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nome:";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Controls.Add(this.nomeAltCat);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(618, 285);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Alterar Categoria";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(191, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 50);
            this.button5.TabIndex = 19;
            this.button5.Text = "Confirmar Alteração";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nomeAltCat
            // 
            this.nomeAltCat.Location = new System.Drawing.Point(78, 15);
            this.nomeAltCat.Name = "nomeAltCat";
            this.nomeAltCat.Size = new System.Drawing.Size(427, 20);
            this.nomeAltCat.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Nome:";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Silver;
            this.tabPage6.Controls.Add(this.btnAlteraCategoria);
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Controls.Add(this.dgCategoria);
            this.tabPage6.Controls.Add(this.textBox9);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(618, 285);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Buscar Categoria";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(540, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgCategoria
            // 
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Location = new System.Drawing.Point(3, 51);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.Size = new System.Drawing.Size(612, 228);
            this.dgCategoria.TabIndex = 15;
            this.dgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellContentClick);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(66, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(175, 20);
            this.textBox9.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nome:";
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.Location = new System.Drawing.Point(12, 149);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(121, 45);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseCompatibleTextRendering = true;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.Location = new System.Drawing.Point(12, 200);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(121, 45);
            this.btnFornecedor.TabIndex = 5;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Image = global::BDDotNet.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(746, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 41);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(-9, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 465);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtidFornecedorAlt
            // 
            this.txtidFornecedorAlt.Location = new System.Drawing.Point(130, 145);
            this.txtidFornecedorAlt.Name = "txtidFornecedorAlt";
            this.txtidFornecedorAlt.Size = new System.Drawing.Size(100, 20);
            this.txtidFornecedorAlt.TabIndex = 18;
            // 
            // txtidCategoriaAlt
            // 
            this.txtidCategoriaAlt.Location = new System.Drawing.Point(130, 181);
            this.txtidCategoriaAlt.Name = "txtidCategoriaAlt";
            this.txtidCategoriaAlt.Size = new System.Drawing.Size(100, 20);
            this.txtidCategoriaAlt.TabIndex = 19;
            // 
            // txtIdProdutoAlt
            // 
            this.txtIdProdutoAlt.Location = new System.Drawing.Point(457, 147);
            this.txtIdProdutoAlt.Name = "txtIdProdutoAlt";
            this.txtIdProdutoAlt.Size = new System.Drawing.Size(100, 20);
            this.txtIdProdutoAlt.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(345, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "id do produto:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // btnAlteraProduto
            // 
            this.btnAlteraProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraProduto.Location = new System.Drawing.Point(446, 12);
            this.btnAlteraProduto.Name = "btnAlteraProduto";
            this.btnAlteraProduto.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraProduto.TabIndex = 7;
            this.btnAlteraProduto.Text = "Alterar";
            this.btnAlteraProduto.UseVisualStyleBackColor = true;
            this.btnAlteraProduto.Click += new System.EventHandler(this.btnAlteraProduto_Click);
            // 
            // btnAlteraCategoria
            // 
            this.btnAlteraCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraCategoria.Location = new System.Drawing.Point(459, 15);
            this.btnAlteraCategoria.Name = "btnAlteraCategoria";
            this.btnAlteraCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraCategoria.TabIndex = 17;
            this.btnAlteraCategoria.Text = "Alterar";
            this.btnAlteraCategoria.UseVisualStyleBackColor = true;
            this.btnAlteraCategoria.Click += new System.EventHandler(this.btnAlteraCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nomeFindCat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.nomeFindCat.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl nomeFindCat;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnremoveprod;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPrecoaltp;
        private System.Windows.Forms.TextBox txtDescaltp;
        private System.Windows.Forms.TextBox txtNomealtp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox nomeCatins;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox nomeAltCat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtCatProd;
        private System.Windows.Forms.TextBox txtFornProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIdProdutoAlt;
        private System.Windows.Forms.TextBox txtidCategoriaAlt;
        private System.Windows.Forms.TextBox txtidFornecedorAlt;
        private System.Windows.Forms.Button btnAlteraProduto;
        private System.Windows.Forms.Button btnAlteraCategoria;
    }
}

