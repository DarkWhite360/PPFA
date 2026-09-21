namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmMovimentacao
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ckbQuitado = new CheckBox();
            txtCodigoPagamento = new TextBox();
            txtCodigoPessoa = new TextBox();
            txtNomePessoa = new TextBox();
            txtDescricaoPagamento = new TextBox();
            txtDataMovimentacao = new MaskedTextBox();
            txtDataPagamento = new MaskedTextBox();
            txtValorTotal = new MaskedTextBox();
            cboFormaPagamento = new ComboBox();
            groupBox1 = new GroupBox();
            btnMenos = new Button();
            cboConta = new ComboBox();
            btnMais = new Button();
            dataGridView1 = new DataGridView();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnConta = new DataGridViewTextBoxColumn();
            clnFormaPagamento = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            clnValor = new DataGridViewTextBoxColumn();
            txtValorPagamento = new MaskedTextBox();
            label11 = new Label();
            label10 = new Label();
            label12 = new Label();
            txtDataVencimento = new MaskedTextBox();
            groupBox2 = new GroupBox();
            btnListarMovimentacoes = new Button();
            btnInativarMoviementacao = new Button();
            btnSalvarPagamento = new Button();
            btnNovoPagamento = new Button();
            btnOpcoes = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Movimentaçoes: Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Cód. Pessoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 101);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 215);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 5;
            label6.Text = "Data Movimentação";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 6;
            label7.Text = "Forma Pgto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(257, 19);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Data Pgto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(268, 215);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 8;
            label9.Text = "Valor Total";
            // 
            // ckbQuitado
            // 
            ckbQuitado.AutoSize = true;
            ckbQuitado.Location = new Point(428, 239);
            ckbQuitado.Name = "ckbQuitado";
            ckbQuitado.Size = new Size(69, 19);
            ckbQuitado.TabIndex = 9;
            ckbQuitado.Text = "Quitado";
            ckbQuitado.UseVisualStyleBackColor = true;
            // 
            // txtCodigoPagamento
            // 
            txtCodigoPagamento.Location = new Point(12, 62);
            txtCodigoPagamento.Name = "txtCodigoPagamento";
            txtCodigoPagamento.Size = new Size(100, 23);
            txtCodigoPagamento.TabIndex = 10;
            // 
            // txtCodigoPessoa
            // 
            txtCodigoPessoa.Location = new Point(12, 119);
            txtCodigoPessoa.Name = "txtCodigoPessoa";
            txtCodigoPessoa.Size = new Size(100, 23);
            txtCodigoPessoa.TabIndex = 11;
            // 
            // txtNomePessoa
            // 
            txtNomePessoa.Location = new Point(164, 119);
            txtNomePessoa.Name = "txtNomePessoa";
            txtNomePessoa.Size = new Size(425, 23);
            txtNomePessoa.TabIndex = 12;
            // 
            // txtDescricaoPagamento
            // 
            txtDescricaoPagamento.Location = new Point(12, 178);
            txtDescricaoPagamento.Name = "txtDescricaoPagamento";
            txtDescricaoPagamento.Size = new Size(100, 23);
            txtDescricaoPagamento.TabIndex = 13;
            // 
            // txtDataMovimentacao
            // 
            txtDataMovimentacao.Location = new Point(12, 233);
            txtDataMovimentacao.Mask = "00/00/0000";
            txtDataMovimentacao.Name = "txtDataMovimentacao";
            txtDataMovimentacao.Size = new Size(114, 23);
            txtDataMovimentacao.TabIndex = 14;
            txtDataMovimentacao.ValidatingType = typeof(DateTime);
            // 
            // txtDataPagamento
            // 
            txtDataPagamento.Location = new Point(257, 37);
            txtDataPagamento.Mask = "00/00/0000";
            txtDataPagamento.Name = "txtDataPagamento";
            txtDataPagamento.Size = new Size(109, 23);
            txtDataPagamento.TabIndex = 16;
            txtDataPagamento.ValidatingType = typeof(DateTime);
            txtDataPagamento.MaskInputRejected += txtDataPagamento_MaskInputRejected;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(268, 235);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(143, 23);
            txtValorTotal.TabIndex = 17;
            // 
            // cboFormaPagamento
            // 
            cboFormaPagamento.FormattingEnabled = true;
            cboFormaPagamento.Location = new Point(130, 37);
            cboFormaPagamento.Name = "cboFormaPagamento";
            cboFormaPagamento.Size = new Size(121, 23);
            cboFormaPagamento.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMenos);
            groupBox1.Controls.Add(cboConta);
            groupBox1.Controls.Add(btnMais);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtValorPagamento);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cboFormaPagamento);
            groupBox1.Controls.Add(txtDataPagamento);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(11, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 176);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lançamentos";
            // 
            // btnMenos
            // 
            btnMenos.Location = new Point(553, 37);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(25, 23);
            btnMenos.TabIndex = 25;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = true;
            // 
            // cboConta
            // 
            cboConta.FormattingEnabled = true;
            cboConta.Location = new Point(8, 37);
            cboConta.Name = "cboConta";
            cboConta.Size = new Size(112, 23);
            cboConta.TabIndex = 23;
            // 
            // btnMais
            // 
            btnMais.Location = new Point(521, 37);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(26, 23);
            btnMais.TabIndex = 24;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCodigo, clnConta, clnFormaPagamento, clnData, clnValor });
            dataGridView1.Location = new Point(6, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(572, 99);
            dataGridView1.TabIndex = 22;
            // 
            // clnCodigo
            // 
            clnCodigo.HeaderText = "#";
            clnCodigo.Name = "clnCodigo";
            // 
            // clnConta
            // 
            clnConta.HeaderText = "Conta";
            clnConta.Name = "clnConta";
            // 
            // clnFormaPagamento
            // 
            clnFormaPagamento.HeaderText = "Forma de Pagamento";
            clnFormaPagamento.Name = "clnFormaPagamento";
            // 
            // clnData
            // 
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            // 
            // clnValor
            // 
            clnValor.HeaderText = "Valor";
            clnValor.Name = "clnValor";
            // 
            // txtValorPagamento
            // 
            txtValorPagamento.Location = new Point(372, 37);
            txtValorPagamento.Name = "txtValorPagamento";
            txtValorPagamento.Size = new Size(143, 23);
            txtValorPagamento.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(372, 19);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 1;
            label11.Text = "Valor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 19);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 0;
            label10.Text = "Conta";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(141, 215);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 20;
            label12.Text = "Data Vencimento";
            // 
            // txtDataVencimento
            // 
            txtDataVencimento.Location = new Point(141, 235);
            txtDataVencimento.Mask = "00/00/0000";
            txtDataVencimento.Name = "txtDataVencimento";
            txtDataVencimento.Size = new Size(114, 23);
            txtDataVencimento.TabIndex = 21;
            txtDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnListarMovimentacoes);
            groupBox2.Controls.Add(btnInativarMoviementacao);
            groupBox2.Controls.Add(btnSalvarPagamento);
            groupBox2.Controls.Add(btnNovoPagamento);
            groupBox2.Location = new Point(11, 462);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(589, 61);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações";
            // 
            // btnListarMovimentacoes
            // 
            btnListarMovimentacoes.Location = new Point(503, 22);
            btnListarMovimentacoes.Name = "btnListarMovimentacoes";
            btnListarMovimentacoes.Size = new Size(75, 23);
            btnListarMovimentacoes.TabIndex = 3;
            btnListarMovimentacoes.Text = "Listar";
            btnListarMovimentacoes.UseVisualStyleBackColor = true;
            // 
            // btnInativarMoviementacao
            // 
            btnInativarMoviementacao.Location = new Point(208, 22);
            btnInativarMoviementacao.Name = "btnInativarMoviementacao";
            btnInativarMoviementacao.Size = new Size(75, 23);
            btnInativarMoviementacao.TabIndex = 2;
            btnInativarMoviementacao.Text = "Inativar";
            btnInativarMoviementacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPagamento
            // 
            btnSalvarPagamento.Location = new Point(106, 22);
            btnSalvarPagamento.Name = "btnSalvarPagamento";
            btnSalvarPagamento.Size = new Size(75, 23);
            btnSalvarPagamento.TabIndex = 1;
            btnSalvarPagamento.Text = "Salvar";
            btnSalvarPagamento.UseVisualStyleBackColor = true;
            // 
            // btnNovoPagamento
            // 
            btnNovoPagamento.Location = new Point(6, 22);
            btnNovoPagamento.Name = "btnNovoPagamento";
            btnNovoPagamento.Size = new Size(75, 23);
            btnNovoPagamento.TabIndex = 0;
            btnNovoPagamento.Text = "Novo";
            btnNovoPagamento.UseVisualStyleBackColor = true;
            // 
            // btnOpcoes
            // 
            btnOpcoes.Location = new Point(118, 119);
            btnOpcoes.Name = "btnOpcoes";
            btnOpcoes.Size = new Size(40, 23);
            btnOpcoes.TabIndex = 23;
            btnOpcoes.Text = "...";
            btnOpcoes.UseVisualStyleBackColor = true;
            // 
            // FrmMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 533);
            Controls.Add(btnOpcoes);
            Controls.Add(groupBox2);
            Controls.Add(txtDataVencimento);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(txtValorTotal);
            Controls.Add(txtDataMovimentacao);
            Controls.Add(txtDescricaoPagamento);
            Controls.Add(txtNomePessoa);
            Controls.Add(txtCodigoPessoa);
            Controls.Add(txtCodigoPagamento);
            Controls.Add(ckbQuitado);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMovimentacao";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox ckbQuitado;
        private TextBox txtCodigoPagamento;
        private TextBox txtCodigoPessoa;
        private TextBox txtNomePessoa;
        private TextBox txtDescricaoPagamento;
        private MaskedTextBox txtDataMovimentacao;
        private MaskedTextBox txtDataPagamento;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox txtValorTotal;
        private ComboBox cboFormaPagamento;
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private MaskedTextBox txtValorPagamento;
        private Label label12;
        private MaskedTextBox txtDataVencimento;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnConta;
        private DataGridViewTextBoxColumn clnFormaPagamento;
        private DataGridViewTextBoxColumn clnData;
        private DataGridViewTextBoxColumn clnValor;
        private ComboBox cboConta;
        private GroupBox groupBox2;
        private Button btnListarMovimentacoes;
        private Button btnInativarMoviementacao;
        private Button btnSalvarPagamento;
        private Button btnNovoPagamento;
        private Button btnOpcoes;
        private Button btnMais;
        private Button btnMenos;
    }
}