namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmContaLista
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
            btnListarContas = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            clnCodigo = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnAgencia = new DataGridViewTextBoxColumn();
            clnConta = new DataGridViewTextBoxColumn();
            clnDigitoVerificador = new DataGridViewTextBoxColumn();
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
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Contas: Listar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnListarContas);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 154);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnListarContas
            // 
            btnListarContas.Location = new Point(597, 101);
            btnListarContas.Name = "btnListarContas";
            btnListarContas.Size = new Size(75, 23);
            btnListarContas.TabIndex = 12;
            btnListarContas.Text = "Listar";
            btnListarContas.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 84);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 11;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 84);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Dígito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 84);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Conta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 19);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Agência";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 19);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Código";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ATIVA", "INATIVA" });
            comboBox1.Location = new Point(456, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(177, 102);
            maskedTextBox3.Mask = "0";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(168, 23);
            maskedTextBox3.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(17, 102);
            maskedTextBox2.Mask = "0000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(154, 23);
            maskedTextBox2.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(456, 37);
            maskedTextBox1.Mask = "0000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnCodigo, clnDescricao, clnAgencia, clnConta, clnDigitoVerificador, clnStatus });
            dataGridView1.Location = new Point(14, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(700, 221);
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
            // clnAgencia
            // 
            clnAgencia.HeaderText = "Agência";
            clnAgencia.Name = "clnAgencia";
            // 
            // clnConta
            // 
            clnConta.HeaderText = "Conta";
            clnConta.Name = "clnConta";
            // 
            // clnDigitoVerificador
            // 
            clnDigitoVerificador.HeaderText = "Dígito";
            clnDigitoVerificador.Name = "clnDigitoVerificador";
            // 
            // clnStatus
            // 
            clnStatus.HeaderText = "Status";
            clnStatus.Name = "clnStatus";
            // 
            // FrmContaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmContaLista";
            Text = "FrmContaLista";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnListarContas;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clnCodigo;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnAgencia;
        private DataGridViewTextBoxColumn clnConta;
        private DataGridViewTextBoxColumn clnDigitoVerificador;
        private DataGridViewTextBoxColumn clnStatus;
    }
}