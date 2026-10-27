namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmConta
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
            txtCodigo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtDescricao = new TextBox();
            txtGerenteConta = new TextBox();
            cbtInstituicaoFinanceira = new ComboBox();
            groupBox1 = new GroupBox();
            btnSalvarConta = new Button();
            btnNovaConta = new Button();
            btnInativarConta = new Button();
            btnListarContas = new Button();
            txtSaldoInicial = new MaskedTextBox();
            txtAgencia = new MaskedTextBox();
            txtConta = new MaskedTextBox();
            txtDigitoVerificador = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Contas: Cadastrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 225);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 4;
            label4.Text = "Agência";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 225);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Conta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(463, 225);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Dígito";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 225);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 7;
            label7.Text = "Instituição Financeira";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 292);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 8;
            label8.Text = "Saldo Inicial";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(333, 292);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 9;
            label9.Text = "Gerente Conta";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 137);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 10;
            // 
            // txtGerenteConta
            // 
            txtGerenteConta.Location = new Point(333, 310);
            txtGerenteConta.Name = "txtGerenteConta";
            txtGerenteConta.Size = new Size(378, 23);
            txtGerenteConta.TabIndex = 15;
            // 
            // cbtInstituicaoFinanceira
            // 
            cbtInstituicaoFinanceira.FormattingEnabled = true;
            cbtInstituicaoFinanceira.Location = new Point(590, 243);
            cbtInstituicaoFinanceira.Name = "cbtInstituicaoFinanceira";
            cbtInstituicaoFinanceira.Size = new Size(121, 23);
            cbtInstituicaoFinanceira.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarContas);
            groupBox1.Controls.Add(btnInativarConta);
            groupBox1.Controls.Add(btnNovaConta);
            groupBox1.Controls.Add(btnSalvarConta);
            groupBox1.Location = new Point(12, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(697, 54);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // btnSalvarConta
            // 
            btnSalvarConta.Location = new Point(101, 22);
            btnSalvarConta.Name = "btnSalvarConta";
            btnSalvarConta.Size = new Size(75, 23);
            btnSalvarConta.TabIndex = 0;
            btnSalvarConta.Text = "Salvar";
            btnSalvarConta.UseVisualStyleBackColor = true;
            // 
            // btnNovaConta
            // 
            btnNovaConta.Location = new Point(6, 21);
            btnNovaConta.Name = "btnNovaConta";
            btnNovaConta.Size = new Size(75, 23);
            btnNovaConta.TabIndex = 1;
            btnNovaConta.Text = "Novo";
            btnNovaConta.UseVisualStyleBackColor = true;
            // 
            // btnInativarConta
            // 
            btnInativarConta.Location = new Point(214, 22);
            btnInativarConta.Name = "btnInativarConta";
            btnInativarConta.Size = new Size(93, 22);
            btnInativarConta.TabIndex = 2;
            btnInativarConta.Text = "Inativar";
            btnInativarConta.UseVisualStyleBackColor = true;
            // 
            // btnListarContas
            // 
            btnListarContas.Location = new Point(616, 22);
            btnListarContas.Name = "btnListarContas";
            btnListarContas.Size = new Size(75, 23);
            btnListarContas.TabIndex = 3;
            btnListarContas.Text = "Listar";
            btnListarContas.UseVisualStyleBackColor = true;
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.Location = new Point(12, 310);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(297, 23);
            txtSaldoInicial.TabIndex = 18;
            txtSaldoInicial.ValidatingType = typeof(int);
            // 
            // txtAgencia
            // 
            txtAgencia.Location = new Point(12, 243);
            txtAgencia.Mask = "0000-0";
            txtAgencia.Name = "txtAgencia";
            txtAgencia.Size = new Size(147, 23);
            txtAgencia.TabIndex = 19;
            // 
            // txtConta
            // 
            txtConta.Location = new Point(165, 243);
            txtConta.Mask = "0000000";
            txtConta.Name = "txtConta";
            txtConta.Size = new Size(292, 23);
            txtConta.TabIndex = 20;
            // 
            // txtDigitoVerificador
            // 
            txtDigitoVerificador.Location = new Point(463, 243);
            txtDigitoVerificador.Mask = "0";
            txtDigitoVerificador.Name = "txtDigitoVerificador";
            txtDigitoVerificador.Size = new Size(121, 23);
            txtDigitoVerificador.TabIndex = 21;
            // 
            // FrmConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 477);
            Controls.Add(txtDigitoVerificador);
            Controls.Add(txtConta);
            Controls.Add(txtAgencia);
            Controls.Add(txtSaldoInicial);
            Controls.Add(groupBox1);
            Controls.Add(cbtInstituicaoFinanceira);
            Controls.Add(txtGerenteConta);
            Controls.Add(txtDescricao);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmConta";
            Text = "FrmConta";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCodigo;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtDescricao;
        private TextBox txtGerenteConta;
        private ComboBox cbtInstituicaoFinanceira;
        private GroupBox groupBox1;
        private Button btnListarContas;
        private Button btnInativarConta;
        private Button btnNovaConta;
        private Button btnSalvarConta;
        private MaskedTextBox txtSaldoInicial;
        private MaskedTextBox txtAgencia;
        private MaskedTextBox txtConta;
        private MaskedTextBox txtDigitoVerificador;
    }
}