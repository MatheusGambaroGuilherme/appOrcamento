namespace Orcamento_RRG.view
{
    partial class ProdutoWindow
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
            btnAdicionar = new Button();
            btnGerenciar = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(81, 120);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(158, 117);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnGerenciar
            // 
            btnGerenciar.Location = new Point(295, 120);
            btnGerenciar.Name = "btnGerenciar";
            btnGerenciar.Size = new Size(158, 117);
            btnGerenciar.TabIndex = 1;
            btnGerenciar.Text = "Gerenciar Produtos";
            btnGerenciar.UseVisualStyleBackColor = true;
            btnGerenciar.Click += btnGerenciar_Click;
            // 
            // ProdutoWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 370);
            Controls.Add(btnGerenciar);
            Controls.Add(btnAdicionar);
            Name = "ProdutoWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionar;
        private Button btnGerenciar;
    }
}