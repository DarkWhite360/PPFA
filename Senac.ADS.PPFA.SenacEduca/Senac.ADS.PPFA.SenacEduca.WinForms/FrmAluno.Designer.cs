namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmAluno
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
            txtTelefone = new MaskedTextBox();
            label2 = new Label();
            btnTurmaLista = new Button();
            label5 = new Label();
            cboTurma = new ComboBox();
            label4 = new Label();
            txtCPF = new MaskedTextBox();
            txtNome = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            groupBox2 = new GroupBox();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnTurmaLista);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboTurma);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Aluno";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 214);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(184, 23);
            txtTelefone.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 196);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 9;
            label2.Text = "Telefone";
            // 
            // btnTurmaLista
            // 
            btnTurmaLista.Location = new Point(397, 146);
            btnTurmaLista.Name = "btnTurmaLista";
            btnTurmaLista.Size = new Size(31, 23);
            btnTurmaLista.TabIndex = 8;
            btnTurmaLista.Text = "...";
            btnTurmaLista.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 128);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "Turna";
            // 
            // cboTurma
            // 
            cboTurma.DisplayMember = "Descricao";
            cboTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurma.FormattingEnabled = true;
            cboTurma.Location = new Point(196, 147);
            cboTurma.Name = "cboTurma";
            cboTurma.Size = new Size(195, 23);
            cboTurma.TabIndex = 6;
            cboTurma.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(6, 146);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(184, 23);
            txtCPF.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(444, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 71);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLocalizar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnNovo);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Location = new Point(12, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 77);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações";
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(307, 34);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(96, 23);
            btnLocalizar.TabIndex = 3;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(205, 34);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(0, 34);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(97, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(103, 34);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(96, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 400);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAluno";
            Text = "Cadastro de Aluno";
            Load += FrmAluno_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox cboTurma;
        private Label label4;
        private MaskedTextBox txtCPF;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtCodigo;
        private Button btnTurmaLista;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnSalvar;
        private MaskedTextBox txtTelefone;
        private Label label2;
    }
}
