namespace Orcamento_RRG.view
{
    partial class NovoProduto
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
            txtNome = new TextBox();
            label2 = new Label();
            txtValorCompra = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtValorVenda = new TextBox();
            label5 = new Label();
            txtCodigo = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor de Compra";
            // 
            // txtValorCompra
            // 
            txtValorCompra.Location = new Point(113, 83);
            txtValorCompra.Name = "txtValorCompra";
            txtValorCompra.Size = new Size(143, 23);
            txtValorCompra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 86);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 116);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Valor de Venda";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(113, 113);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.Size = new Size(143, 23);
            txtValorVenda.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(64, 50);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(209, 23);
            txtCodigo.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(113, 150);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(151, 33);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // NovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 195);
            Controls.Add(btnSalvar);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(txtValorVenda);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValorCompra);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "NovoProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Produto";
            Load += NovoProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtValorCompra;
        private Label label3;
        private Label label4;
        private TextBox txtValorVenda;
        private Label label5;
        private TextBox txtCodigo;
        private Button btnSalvar;
    }
}