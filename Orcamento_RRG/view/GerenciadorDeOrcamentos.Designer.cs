namespace Orcamento_RRG.view
{
    partial class GerenciadorDeOrcamentos
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
            dgvOrcamentos = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            data = new DataGridViewTextBoxColumn();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvOrcamentos
            // 
            dgvOrcamentos.AllowUserToAddRows = false;
            dgvOrcamentos.AllowUserToDeleteRows = false;
            dgvOrcamentos.AllowUserToResizeColumns = false;
            dgvOrcamentos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrcamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrcamentos.Columns.AddRange(new DataGridViewColumn[] { numero, cliente, data });
            dgvOrcamentos.EnableHeadersVisualStyles = false;
            dgvOrcamentos.Location = new Point(12, 12);
            dgvOrcamentos.MultiSelect = false;
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.ReadOnly = true;
            dgvOrcamentos.RowHeadersVisible = false;
            dgvOrcamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrcamentos.Size = new Size(523, 286);
            dgvOrcamentos.TabIndex = 18;
            dgvOrcamentos.DoubleClick += dgvOrcamentos_DoubleClick;
            // 
            // numero
            // 
            numero.HeaderText = "Número";
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Width = 150;
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            cliente.Width = 200;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            data.Width = 150;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(401, 304);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(134, 23);
            btnExcluir.TabIndex = 19;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // GerenciadorDeOrcamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 333);
            Controls.Add(btnExcluir);
            Controls.Add(dgvOrcamentos);
            Name = "GerenciadorDeOrcamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GerenciadorDeOrcamentos";
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrcamentos;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn data;
        private Button btnExcluir;
    }
}