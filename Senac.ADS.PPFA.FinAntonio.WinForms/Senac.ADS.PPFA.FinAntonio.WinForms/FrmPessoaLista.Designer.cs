namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmPessoaLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnFiltrar = new Button();
            txtCodigoPessoa = new TextBox();
            txtNome = new TextBox();
            txtCpf = new MaskedTextBox();
            txtRg = new MaskedTextBox();
            cboStatus = new ComboBox();
            dataGridView1 = new DataGridView();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnNomePessoa = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnRg = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUf = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Pessoas: Listar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(txtRg);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtCodigoPessoa);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 37);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 81);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 81);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 4;
            label5.Text = "RG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 81);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(527, 98);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtCodigoPessoa
            // 
            txtCodigoPessoa.Location = new Point(15, 55);
            txtCodigoPessoa.Name = "txtCodigoPessoa";
            txtCodigoPessoa.Size = new Size(100, 23);
            txtCodigoPessoa.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(476, 23);
            txtNome.TabIndex = 8;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(15, 99);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(151, 23);
            txtCpf.TabIndex = 9;
            // 
            // txtRg
            // 
            txtRg.Location = new Point(177, 99);
            txtRg.Mask = "00,000,000-0";
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(142, 23);
            txtRg.TabIndex = 10;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "ATIVO", "INATIVO" });
            cboStatus.Location = new Point(325, 99);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(111, 23);
            cboStatus.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCodigo, clnNomePessoa, clnCpf, clnRg, clnCidade, clnUf });
            dataGridView1.Location = new Point(16, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(660, 228);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "Código";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnNomePessoa
            // 
            clnNomePessoa.HeaderText = "Nome";
            clnNomePessoa.Name = "clnNomePessoa";
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            // 
            // clnRg
            // 
            clnRg.HeaderText = "RG";
            clnRg.Name = "clnRg";
            // 
            // clnCidade
            // 
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            // 
            // clnUf
            // 
            clnUf.HeaderText = "UF";
            clnUf.Name = "clnUf";
            // 
            // FrmPessoaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmPessoaLista";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboStatus;
        private MaskedTextBox txtRg;
        private MaskedTextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtCodigoPessoa;
        private Button btnFiltrar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnNomePessoa;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnRg;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUf;
    }
}
