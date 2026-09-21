namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmMovimentacaoLista
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigoMovimentacao = new TextBox();
            txtCodigoPessoa = new TextBox();
            txtNome = new TextBox();
            txtDataMovimentacao = new MaskedTextBox();
            txtDataVencimento = new MaskedTextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            btnOpcoes = new Button();
            btnFiltrarMovimentacoes = new Button();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnCodigoPessoa = new DataGridViewTextBoxColumn();
            clnPessoa = new DataGridViewTextBoxColumn();
            clnDataMovimentacao = new DataGridViewTextBoxColumn();
            clnDataVencimento = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            clnStatus = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Movimentações: Listar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrarMovimentacoes);
            groupBox1.Controls.Add(btnOpcoes);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtDataVencimento);
            groupBox1.Controls.Add(txtDataMovimentacao);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtCodigoPessoa);
            groupBox1.Controls.Add(txtCodigoMovimentacao);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 371);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 39);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 1;
            label3.Text = "Cód. Pessoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 39);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 2;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 94);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 3;
            label5.Text = "Data Movimentação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 94);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 4;
            label6.Text = "Data Vencimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 94);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Status";
            // 
            // txtCodigoMovimentacao
            // 
            txtCodigoMovimentacao.Location = new Point(6, 57);
            txtCodigoMovimentacao.Name = "txtCodigoMovimentacao";
            txtCodigoMovimentacao.Size = new Size(100, 23);
            txtCodigoMovimentacao.TabIndex = 6;
            // 
            // txtCodigoPessoa
            // 
            txtCodigoPessoa.Location = new Point(117, 57);
            txtCodigoPessoa.Name = "txtCodigoPessoa";
            txtCodigoPessoa.Size = new Size(100, 23);
            txtCodigoPessoa.TabIndex = 7;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(256, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(249, 23);
            txtNome.TabIndex = 8;
            // 
            // txtDataMovimentacao
            // 
            txtDataMovimentacao.Location = new Point(6, 112);
            txtDataMovimentacao.Mask = "00/00/0000";
            txtDataMovimentacao.Name = "txtDataMovimentacao";
            txtDataMovimentacao.Size = new Size(114, 23);
            txtDataMovimentacao.TabIndex = 9;
            txtDataMovimentacao.ValidatingType = typeof(DateTime);
            // 
            // txtDataVencimento
            // 
            txtDataVencimento.Location = new Point(142, 112);
            txtDataVencimento.Mask = "00/00/0000";
            txtDataVencimento.Name = "txtDataVencimento";
            txtDataVencimento.Size = new Size(125, 23);
            txtDataVencimento.TabIndex = 10;
            txtDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pendente", "Pago", "Vencido" });
            comboBox1.Location = new Point(291, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCodigo, clnCodigoPessoa, clnPessoa, clnDataMovimentacao, clnDataVencimento, clnValor, clnStatus });
            dataGridView1.Location = new Point(6, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(749, 197);
            dataGridView1.TabIndex = 12;
            // 
            // btnOpcoes
            // 
            btnOpcoes.Location = new Point(223, 57);
            btnOpcoes.Name = "btnOpcoes";
            btnOpcoes.Size = new Size(27, 23);
            btnOpcoes.TabIndex = 13;
            btnOpcoes.Text = "...";
            btnOpcoes.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarMovimentacoes
            // 
            btnFiltrarMovimentacoes.Location = new Point(430, 112);
            btnFiltrarMovimentacoes.Name = "btnFiltrarMovimentacoes";
            btnFiltrarMovimentacoes.Size = new Size(75, 25);
            btnFiltrarMovimentacoes.TabIndex = 14;
            btnFiltrarMovimentacoes.Text = "Filtrar";
            btnFiltrarMovimentacoes.UseVisualStyleBackColor = true;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "#";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnCodigoPessoa
            // 
            clnCodigoPessoa.HeaderText = "Cód. Pessoa";
            clnCodigoPessoa.Name = "clnCodigoPessoa";
            // 
            // clnPessoa
            // 
            clnPessoa.HeaderText = "Pessoa";
            clnPessoa.Name = "clnPessoa";
            // 
            // clnDataMovimentacao
            // 
            clnDataMovimentacao.HeaderText = "Data Movimen.";
            clnDataMovimentacao.Name = "clnDataMovimentacao";
            // 
            // clnDataVencimento
            // 
            clnDataVencimento.HeaderText = "Data Vcto";
            clnDataVencimento.Name = "clnDataVencimento";
            // 
            // clnValor
            // 
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            // 
            // FrmMovimentacaoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmMovimentacaoLista";
            Text = "FrmMovimentacaoLista";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCodigoMovimentacao;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFiltrarMovimentacoes;
        private Button btnOpcoes;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private MaskedTextBox txtDataVencimento;
        private MaskedTextBox txtDataMovimentacao;
        private TextBox txtNome;
        private TextBox txtCodigoPessoa;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnCodigoPessoa;
        private DataGridViewTextBoxColumn clnPessoa;
        private DataGridViewTextBoxColumn clnDataMovimentacao;
        private DataGridViewTextBoxColumn clnDataVencimento;
        private DataGridViewTextBoxColumn clnValor;
        private DataGridViewTextBoxColumn clnStatus;
    }
}