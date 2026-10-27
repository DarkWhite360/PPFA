namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmFormaPagamento
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ckbBaixaSaldo = new CheckBox();
            groupBox1 = new GroupBox();
            btnNovaFormaPagamento = new Button();
            btnSalvarFormaPagamento = new Button();
            btnInativarFormaPagamento = new Button();
            btnListarFormaPagametno = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 0;
            label1.Text = "Formas de Pagamento: Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(558, 23);
            textBox2.TabIndex = 4;
            // 
            // ckbBaixaSaldo
            // 
            ckbBaixaSaldo.AutoSize = true;
            ckbBaixaSaldo.Location = new Point(12, 146);
            ckbBaixaSaldo.Name = "ckbBaixaSaldo";
            ckbBaixaSaldo.Size = new Size(136, 19);
            ckbBaixaSaldo.TabIndex = 5;
            ckbBaixaSaldo.Text = "Baixa Saldo da Conta";
            ckbBaixaSaldo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarFormaPagametno);
            groupBox1.Controls.Add(btnInativarFormaPagamento);
            groupBox1.Controls.Add(btnSalvarFormaPagamento);
            groupBox1.Controls.Add(btnNovaFormaPagamento);
            groupBox1.Location = new Point(12, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 58);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // btnNovaFormaPagamento
            // 
            btnNovaFormaPagamento.Location = new Point(6, 22);
            btnNovaFormaPagamento.Name = "btnNovaFormaPagamento";
            btnNovaFormaPagamento.Size = new Size(75, 23);
            btnNovaFormaPagamento.TabIndex = 0;
            btnNovaFormaPagamento.Text = "Novo";
            btnNovaFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // btnSalvarFormaPagamento
            // 
            btnSalvarFormaPagamento.Location = new Point(87, 22);
            btnSalvarFormaPagamento.Name = "btnSalvarFormaPagamento";
            btnSalvarFormaPagamento.Size = new Size(75, 23);
            btnSalvarFormaPagamento.TabIndex = 1;
            btnSalvarFormaPagamento.Text = "Salvar";
            btnSalvarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // btnInativarFormaPagamento
            // 
            btnInativarFormaPagamento.Location = new Point(168, 22);
            btnInativarFormaPagamento.Name = "btnInativarFormaPagamento";
            btnInativarFormaPagamento.Size = new Size(75, 23);
            btnInativarFormaPagamento.TabIndex = 2;
            btnInativarFormaPagamento.Text = "Inativar";
            btnInativarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // btnListarFormaPagametno
            // 
            btnListarFormaPagametno.Location = new Point(477, 22);
            btnListarFormaPagametno.Name = "btnListarFormaPagametno";
            btnListarFormaPagametno.Size = new Size(75, 23);
            btnListarFormaPagametno.TabIndex = 3;
            btnListarFormaPagametno.Text = "Listar";
            btnListarFormaPagametno.UseVisualStyleBackColor = true;
            // 
            // FrmFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 260);
            Controls.Add(groupBox1);
            Controls.Add(ckbBaixaSaldo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFormaPagamento";
            Text = "FrmFormaPagamento";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox ckbBaixaSaldo;
        private GroupBox groupBox1;
        private Button btnListarFormaPagametno;
        private Button btnInativarFormaPagamento;
        private Button btnSalvarFormaPagamento;
        private Button btnNovaFormaPagamento;
    }
}