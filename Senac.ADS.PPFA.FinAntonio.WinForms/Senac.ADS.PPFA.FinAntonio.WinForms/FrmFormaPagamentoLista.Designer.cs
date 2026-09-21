namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmFormaPagamentoLista
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            ckbBaixaSaldo = new CheckBox();
            dataGridView1 = new DataGridView();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnBaixaSaldo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Formas de Pagamento: Listar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckbBaixaSaldo);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 102);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 30);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 1;
            label3.Text = "Descrição";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(15, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(133, 48);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(355, 23);
            txtDescricao.TabIndex = 3;
            // 
            // ckbBaixaSaldo
            // 
            ckbBaixaSaldo.AutoSize = true;
            ckbBaixaSaldo.Location = new Point(15, 77);
            ckbBaixaSaldo.Name = "ckbBaixaSaldo";
            ckbBaixaSaldo.Size = new Size(136, 19);
            ckbBaixaSaldo.TabIndex = 4;
            ckbBaixaSaldo.Text = "Baixa Saldo de Conta";
            ckbBaixaSaldo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCodigo, clnDescricao, clnBaixaSaldo });
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(509, 208);
            dataGridView1.TabIndex = 2;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "#";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            // 
            // clnBaixaSaldo
            // 
            clnBaixaSaldo.HeaderText = "Baixa Saldo de Conta";
            clnBaixaSaldo.Name = "clnBaixaSaldo";
            // 
            // FrmFormaPagamentoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 370);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmFormaPagamentoLista";
            Text = "FrmFormaPagaemntoLista";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private CheckBox ckbBaixaSaldo;
        private TextBox txtDescricao;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnBaixaSaldo;
    }
}