namespace Orcamento_RRG.view
{
    partial class AlterarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtCodigo = new TextBox();
            label5 = new Label();
            txtValorVenda = new TextBox();
            label4 = new Label();
            txtValorCompra = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            dgvProdutos = new DataGridView();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            panel1 = new Panel();
            btn_Novo = new Button();
            label3 = new Label();
            cboxPesquisa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(64, 95);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(209, 23);
            txtCodigo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 98);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 15;
            label5.Text = "Codigo";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(113, 158);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(143, 23);
            txtValorVenda.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 161);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Valor de Venda";
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(113, 128);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(143, 23);
            txtValorCompra.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Valor de Compra";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 61);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 23);
            txtNome.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;
            dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.Location = new Point(368, 33);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(322, 209);
            dgvProdutos.TabIndex = 16;
            dgvProdutos.SelectionChanged += dgvProdutos_SelectionChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(191, 24);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(128, 23);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(325, 24);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 23);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir Produto";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(459, 24);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(82, 23);
            btnSair.TabIndex = 19;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btn_Novo);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnExcluir);
            panel1.Location = new Point(-54, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 63);
            panel1.TabIndex = 20;
            // 
            // btn_Novo
            // 
            btn_Novo.Location = new Point(57, 24);
            btn_Novo.Name = "btn_Novo";
            btn_Novo.Size = new Size(128, 23);
            btn_Novo.TabIndex = 20;
            btn_Novo.Text = "Novo Produto";
            btn_Novo.UseVisualStyleBackColor = true;
            btn_Novo.Click += btn_Novo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 9);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 21;
            label3.Text = "Pesquisar por:";
            // 
            // cboxPesquisa
            // 
            cboxPesquisa.FormattingEnabled = true;
            cboxPesquisa.Items.AddRange(new object[] { "Nome", "Valor de Venda", "Valor de Compra" });
            cboxPesquisa.Location = new Point(446, 6);
            cboxPesquisa.Name = "cboxPesquisa";
            cboxPesquisa.Size = new Size(220, 23);
            cboxPesquisa.TabIndex = 22;
            cboxPesquisa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AlterarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 307);
            Controls.Add(cboxPesquisa);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dgvProdutos);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(txtValorVenda);
            Controls.Add(label4);
            Controls.Add(txtValorCompra);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "AlterarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarProduto";
            Load += AlterarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label label5;
        private TextBox txtValorVenda;
        private Label label4;
        private TextBox txtValorCompra;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private DataGridView dgvProdutos;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnSair;
        private Panel panel1;
        private Button btn_Novo;
        private Label label3;
        private ComboBox cboxPesquisa;
    }
}