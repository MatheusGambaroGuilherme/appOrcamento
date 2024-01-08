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
            lboxProdutos = new Label();
            btnSalvar = new Button();
            listBox1 = new ListBox();
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 337);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Custo";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Location = new Point(601, 337);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(0, 15);
            lblCusto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 367);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor";
            // 
            // lboxProdutos
            // 
            lboxProdutos.AutoSize = true;
            lboxProdutos.Location = new Point(601, 367);
            lboxProdutos.Name = "lboxProdutos";
            lboxProdutos.Size = new Size(0, 15);
            lboxProdutos.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(557, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(215, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(523, 289);
            listBox1.TabIndex = 13;
            // 
            // NovoOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnSalvar);
            Controls.Add(lboxProdutos);
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
        private Label lboxProdutos;
        private Button btnSalvar;
        private ListBox listBox1;
    }
}