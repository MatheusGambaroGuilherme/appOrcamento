namespace Orcamento_RRG.view
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            btnProdutos = new ToolStripMenuItem();
            btnOrcamentos = new ToolStripMenuItem();
            opçõesToolStripMenuItem1 = new ToolStripMenuItem();
            exportarOrçamentosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnNovo = new Button();
            btnGerenciar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, opçõesToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(572, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnProdutos, btnOrcamentos });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(67, 20);
            opçõesToolStripMenuItem.Text = "Produtos";
            // 
            // btnProdutos
            // 
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(175, 22);
            btnProdutos.Text = "Novo Produto";
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnOrcamentos
            // 
            btnOrcamentos.Name = "btnOrcamentos";
            btnOrcamentos.Size = new Size(175, 22);
            btnOrcamentos.Text = "Gerenciar Produtos";
            btnOrcamentos.Click += btnOrcamentos_Click;
            // 
            // opçõesToolStripMenuItem1
            // 
            opçõesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exportarOrçamentosToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            opçõesToolStripMenuItem1.Name = "opçõesToolStripMenuItem1";
            opçõesToolStripMenuItem1.Size = new Size(59, 20);
            opçõesToolStripMenuItem1.Text = "Opções";
            // 
            // exportarOrçamentosToolStripMenuItem
            // 
            exportarOrçamentosToolStripMenuItem.Name = "exportarOrçamentosToolStripMenuItem";
            exportarOrçamentosToolStripMenuItem.Size = new Size(186, 22);
            exportarOrçamentosToolStripMenuItem.Text = "Exportar Orçamentos";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(183, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(186, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(90, 122);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(135, 111);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo Orçamento";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnGerenciar
            // 
            btnGerenciar.Location = new Point(332, 122);
            btnGerenciar.Name = "btnGerenciar";
            btnGerenciar.Size = new Size(135, 111);
            btnGerenciar.TabIndex = 2;
            btnGerenciar.Text = "Gerenciar Orçamentos";
            btnGerenciar.UseVisualStyleBackColor = true;
            btnGerenciar.Click += btnGerenciar_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 329);
            Controls.Add(btnGerenciar);
            Controls.Add(btnNovo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orçamentos";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem btnProdutos;
        private ToolStripMenuItem btnOrcamentos;
        private Button btnNovo;
        private Button btnGerenciar;
        private ToolStripMenuItem opçõesToolStripMenuItem1;
        private ToolStripMenuItem exportarOrçamentosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}