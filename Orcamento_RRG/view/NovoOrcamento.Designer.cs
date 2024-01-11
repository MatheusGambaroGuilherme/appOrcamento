namespace Orcamento_RRG.view
{
    partial class NovoOrcamento
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
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            txtData = new MaskedTextBox();
            label3 = new Label();
            txtNumeroOrcamento = new TextBox();
            label4 = new Label();
            cboxProduto = new ComboBox();
            label5 = new Label();
            lblCusto = new Label();
            label6 = new Label();
            lblValor = new Label();
            btnSalvar = new Button();
            dgvProdutos = new DataGridView();
            nomeProduto = new DataGridViewTextBoxColumn();
            precoCompra = new DataGridViewTextBoxColumn();
            precoVenda = new DataGridViewTextBoxColumn();
            qntProduto = new DataGridViewTextBoxColumn();
            totalVendaProduto = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btnAumentarProduto = new Button();
            btnDiminuirProduto = new Button();
            btnRemover = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(62, 15);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(319, 23);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 20);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // txtData
            // 
            txtData.Location = new Point(435, 15);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 3;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Número Orçamento";
            // 
            // txtNumeroOrcamento
            // 
            txtNumeroOrcamento.Location = new Point(132, 49);
            txtNumeroOrcamento.Name = "txtNumeroOrcamento";
            txtNumeroOrcamento.Size = new Size(100, 23);
            txtNumeroOrcamento.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "Adicionar Produto";
            // 
            // cboxProduto
            // 
            cboxProduto.FormattingEnabled = true;
            cboxProduto.Location = new Point(122, 102);
            cboxProduto.Name = "cboxProduto";
            cboxProduto.Size = new Size(413, 23);
            cboxProduto.TabIndex = 7;
            cboxProduto.SelectedIndexChanged += cboxProduto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(559, 28);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Custo";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Location = new Point(603, 28);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(0, 15);
            lblCusto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 58);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(603, 58);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(0, 15);
            lblValor.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(559, 97);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(215, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
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
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { nomeProduto, precoCompra, precoVenda, qntProduto, totalVendaProduto });
            dgvProdutos.EnableHeadersVisualStyles = false;
            dgvProdutos.Location = new Point(12, 143);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(523, 286);
            dgvProdutos.TabIndex = 17;
            // 
            // nomeProduto
            // 
            nomeProduto.HeaderText = "Nome";
            nomeProduto.Name = "nomeProduto";
            nomeProduto.ReadOnly = true;
            // 
            // precoCompra
            // 
            precoCompra.HeaderText = "Preço de Compra";
            precoCompra.Name = "precoCompra";
            precoCompra.ReadOnly = true;
            // 
            // precoVenda
            // 
            precoVenda.HeaderText = "Preço de Venda";
            precoVenda.Name = "precoVenda";
            precoVenda.ReadOnly = true;
            // 
            // qntProduto
            // 
            qntProduto.HeaderText = "Quantidade";
            qntProduto.Name = "qntProduto";
            qntProduto.ReadOnly = true;
            // 
            // totalVendaProduto
            // 
            totalVendaProduto.HeaderText = "Preço Total Venda";
            totalVendaProduto.Name = "totalVendaProduto";
            totalVendaProduto.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(541, 379);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 18;
            label7.Text = "Quantidade:";
            // 
            // btnAumentarProduto
            // 
            btnAumentarProduto.Location = new Point(619, 372);
            btnAumentarProduto.Name = "btnAumentarProduto";
            btnAumentarProduto.Size = new Size(20, 28);
            btnAumentarProduto.TabIndex = 19;
            btnAumentarProduto.Text = "+";
            btnAumentarProduto.UseVisualStyleBackColor = true;
            btnAumentarProduto.Click += btnAumentarProduto_Click;
            // 
            // btnDiminuirProduto
            // 
            btnDiminuirProduto.Location = new Point(645, 372);
            btnDiminuirProduto.Name = "btnDiminuirProduto";
            btnDiminuirProduto.Size = new Size(20, 28);
            btnDiminuirProduto.TabIndex = 20;
            btnDiminuirProduto.Text = "-";
            btnDiminuirProduto.UseVisualStyleBackColor = true;
            btnDiminuirProduto.Click += btnDiminuirProduto_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(541, 406);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(124, 23);
            btnRemover.TabIndex = 21;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(559, 143);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(215, 23);
            btnExportar.TabIndex = 22;
            btnExportar.Text = "Exportar Orçamento";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // NovoOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportar);
            Controls.Add(btnRemover);
            Controls.Add(btnDiminuirProduto);
            Controls.Add(btnAumentarProduto);
            Controls.Add(label7);
            Controls.Add(dgvProdutos);
            Controls.Add(btnSalvar);
            Controls.Add(lblValor);
            Controls.Add(label6);
            Controls.Add(lblCusto);
            Controls.Add(label5);
            Controls.Add(cboxProduto);
            Controls.Add(label4);
            Controls.Add(txtNumeroOrcamento);
            Controls.Add(label3);
            Controls.Add(txtData);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "NovoOrcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NovoOrcamento";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private MaskedTextBox txtData;
        private Label label3;
        private TextBox txtNumeroOrcamento;
        private Label label4;
        private ComboBox cboxProduto;
        private Label label5;
        private Label lblCusto;
        private Label label6;
        private Label lblValor;
        private Button btnSalvar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn nomeProduto;
        private DataGridViewTextBoxColumn precoCompra;
        private DataGridViewTextBoxColumn precoVenda;
        private DataGridViewTextBoxColumn qntProduto;
        private DataGridViewTextBoxColumn totalVendaProduto;
        private Label label7;
        private Button btnAumentarProduto;
        private Button btnDiminuirProduto;
        private Button btnRemover;
        private Button btnExportar;
    }
}