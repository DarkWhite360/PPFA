namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmPessoa
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
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtCodigoPessoa = new TextBox();
            txtNomePessoa = new TextBox();
            txtDataNascimento = new MaskedTextBox();
            txtEndereco = new TextBox();
            txtEnderecoNumero = new TextBox();
            cbtUf = new ComboBox();
            txtCep = new MaskedTextBox();
            txtEnderecoComplemento = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnNovaPessoa = new Button();
            btnSalvarPessoa = new Button();
            btnInativarPessoa = new Button();
            btnListarPessoas = new Button();
            txtCpf = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            txtCidade = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Pessoas: Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 144);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 3;
            label4.Text = "RG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 144);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 4;
            label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 5;
            label6.Text = "Endereço";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 221);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 6;
            label7.Text = "Nº";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 285);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 7;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(171, 285);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 8;
            label9.Text = "UF";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(246, 285);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 9;
            label10.Text = "CEP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(413, 285);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 10;
            label11.Text = "Complemento";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 144);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 11;
            label12.Text = "CPF";
            // 
            // txtCodigoPessoa
            // 
            txtCodigoPessoa.Location = new Point(13, 59);
            txtCodigoPessoa.Name = "txtCodigoPessoa";
            txtCodigoPessoa.Size = new Size(100, 23);
            txtCodigoPessoa.TabIndex = 12;
            // 
            // txtNomePessoa
            // 
            txtNomePessoa.Location = new Point(12, 103);
            txtNomePessoa.Name = "txtNomePessoa";
            txtNomePessoa.Size = new Size(545, 23);
            txtNomePessoa.TabIndex = 13;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(437, 162);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(120, 23);
            txtDataNascimento.TabIndex = 16;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(13, 239);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(438, 23);
            txtEndereco.TabIndex = 17;
            // 
            // txtEnderecoNumero
            // 
            txtEnderecoNumero.Location = new Point(457, 239);
            txtEnderecoNumero.Name = "txtEnderecoNumero";
            txtEnderecoNumero.Size = new Size(100, 23);
            txtEnderecoNumero.TabIndex = 18;
            // 
            // cbtUf
            // 
            cbtUf.FormattingEnabled = true;
            cbtUf.Items.AddRange(new object[] { "AC", "", "AL", "", "AM", "", "AP", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MG", "", "MS", "", "MT", "", "PA", "", "PB", "", "PE", "", "PI", "", "PR", "", "RJ", "", "RN", "", "RO", "", "RR", "", "RS", "", "SC", "", "SE", "", "SP", "", "TO" });
            cbtUf.Location = new Point(171, 301);
            cbtUf.Name = "cbtUf";
            cbtUf.Size = new Size(70, 23);
            cbtUf.TabIndex = 20;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(247, 301);
            txtCep.Mask = "00,000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(160, 23);
            txtCep.TabIndex = 21;
            // 
            // txtEnderecoComplemento
            // 
            txtEnderecoComplemento.Location = new Point(413, 303);
            txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            txtEnderecoComplemento.Size = new Size(144, 23);
            txtEnderecoComplemento.TabIndex = 22;
            txtEnderecoComplemento.MaskInputRejected += txtComplemento_MaskInputRejected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarPessoas);
            groupBox1.Controls.Add(btnInativarPessoa);
            groupBox1.Controls.Add(btnSalvarPessoa);
            groupBox1.Controls.Add(btnNovaPessoa);
            groupBox1.Location = new Point(12, 372);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 57);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // btnNovaPessoa
            // 
            btnNovaPessoa.Location = new Point(23, 23);
            btnNovaPessoa.Name = "btnNovaPessoa";
            btnNovaPessoa.Size = new Size(78, 27);
            btnNovaPessoa.TabIndex = 0;
            btnNovaPessoa.Text = "Novo";
            btnNovaPessoa.UseVisualStyleBackColor = true;
            // 
            // btnSalvarPessoa
            // 
            btnSalvarPessoa.Location = new Point(140, 24);
            btnSalvarPessoa.Name = "btnSalvarPessoa";
            btnSalvarPessoa.Size = new Size(89, 25);
            btnSalvarPessoa.TabIndex = 1;
            btnSalvarPessoa.Text = "Salvar";
            btnSalvarPessoa.UseVisualStyleBackColor = true;
            // 
            // btnInativarPessoa
            // 
            btnInativarPessoa.Location = new Point(252, 22);
            btnInativarPessoa.Name = "btnInativarPessoa";
            btnInativarPessoa.Size = new Size(77, 27);
            btnInativarPessoa.TabIndex = 2;
            btnInativarPessoa.Text = "Inativar";
            btnInativarPessoa.UseVisualStyleBackColor = true;
            // 
            // btnListarPessoas
            // 
            btnListarPessoas.Location = new Point(433, 22);
            btnListarPessoas.Name = "btnListarPessoas";
            btnListarPessoas.Size = new Size(106, 27);
            btnListarPessoas.TabIndex = 3;
            btnListarPessoas.Text = "Listar";
            btnListarPessoas.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(13, 162);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(200, 23);
            txtCpf.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(219, 162);
            maskedTextBox1.Mask = "00,000,000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 23);
            maskedTextBox1.TabIndex = 25;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 303);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(153, 23);
            txtCidade.TabIndex = 26;
            // 
            // FrmPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 450);
            Controls.Add(txtCidade);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtCpf);
            Controls.Add(groupBox1);
            Controls.Add(txtEnderecoComplemento);
            Controls.Add(txtCep);
            Controls.Add(cbtUf);
            Controls.Add(txtEnderecoNumero);
            Controls.Add(txtEndereco);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtNomePessoa);
            Controls.Add(txtCodigoPessoa);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPessoa";
            Text = "FrmPessoa";
            groupBox1.ResumeLayout(false);
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
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtCodigoPessoa;
        private TextBox txtNomePessoa;
        private MaskedTextBox txtDataNascimento;
        private TextBox txtEndereco;
        private TextBox txtEnderecoNumero;
        private ComboBox cbtUf;
        private MaskedTextBox txtCep;
        private MaskedTextBox txtEnderecoComplemento;
        private GroupBox groupBox1;
        private Button btnListarPessoas;
        private Button btnInativarPessoa;
        private Button btnSalvarPessoa;
        private Button btnNovaPessoa;
        private MaskedTextBox txtCpf;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtCidade;
    }
}