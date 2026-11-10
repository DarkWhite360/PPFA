namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmAluno1
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
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCpf = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboTurma = new ReaLTaiizor.Controls.MaterialComboBox();
            btnTurmaLista = new ReaLTaiizor.Controls.MaterialButton();
            txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            btnLocalizar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(6, 67);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(250, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.Text = "0";
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 121);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(625, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            txtCpf.AllowPromptAsInput = true;
            txtCpf.AnimateReadOnly = false;
            txtCpf.AsciiOnly = false;
            txtCpf.BackgroundImageLayout = ImageLayout.None;
            txtCpf.BeepOnError = false;
            txtCpf.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.Depth = 0;
            txtCpf.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpf.HidePromptOnLeave = false;
            txtCpf.HideSelection = true;
            txtCpf.Hint = "CPF";
            txtCpf.InsertKeyMode = InsertKeyMode.Default;
            txtCpf.LeadingIcon = null;
            txtCpf.Location = new Point(6, 175);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.MaxLength = 32767;
            txtCpf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCpf.Name = "txtCpf";
            txtCpf.PasswordChar = '\0';
            txtCpf.PrefixSuffixText = null;
            txtCpf.PromptChar = '_';
            txtCpf.ReadOnly = false;
            txtCpf.RejectInputOnFirstFailure = false;
            txtCpf.ResetOnPrompt = true;
            txtCpf.ResetOnSpace = true;
            txtCpf.RightToLeft = RightToLeft.No;
            txtCpf.SelectedText = "";
            txtCpf.SelectionLength = 0;
            txtCpf.SelectionStart = 0;
            txtCpf.ShortcutsEnabled = true;
            txtCpf.Size = new Size(250, 48);
            txtCpf.SkipLiterals = true;
            txtCpf.TabIndex = 2;
            txtCpf.TabStop = false;
            txtCpf.Text = "   .   .   -";
            txtCpf.TextAlign = HorizontalAlignment.Left;
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCpf.TrailingIcon = null;
            txtCpf.UseSystemPasswordChar = false;
            txtCpf.ValidatingType = null;
            // 
            // cboTurma
            // 
            cboTurma.AutoResize = false;
            cboTurma.BackColor = Color.FromArgb(255, 255, 255);
            cboTurma.Depth = 0;
            cboTurma.DrawMode = DrawMode.OwnerDrawVariable;
            cboTurma.DropDownHeight = 174;
            cboTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurma.DropDownWidth = 121;
            cboTurma.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTurma.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTurma.FormattingEnabled = true;
            cboTurma.Hint = "Turma";
            cboTurma.IntegralHeight = false;
            cboTurma.ItemHeight = 43;
            cboTurma.Location = new Point(288, 175);
            cboTurma.MaxDropDownItems = 4;
            cboTurma.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTurma.Name = "cboTurma";
            cboTurma.Size = new Size(121, 49);
            cboTurma.StartIndex = 0;
            cboTurma.TabIndex = 3;
            // 
            // btnTurmaLista
            // 
            btnTurmaLista.AutoSize = false;
            btnTurmaLista.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTurmaLista.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnTurmaLista.Depth = 0;
            btnTurmaLista.HighEmphasis = true;
            btnTurmaLista.Icon = null;
            btnTurmaLista.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnTurmaLista.Location = new Point(424, 175);
            btnTurmaLista.Margin = new Padding(0, 0, 0, 0);
            btnTurmaLista.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnTurmaLista.Name = "btnTurmaLista";
            btnTurmaLista.NoAccentTextColor = Color.Empty;
            btnTurmaLista.Size = new Size(53, 49);
            btnTurmaLista.TabIndex = 4;
            btnTurmaLista.Text = "...";
            btnTurmaLista.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnTurmaLista.UseAccentColor = false;
            btnTurmaLista.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            txtTelefone.AllowPromptAsInput = true;
            txtTelefone.AnimateReadOnly = false;
            txtTelefone.AsciiOnly = false;
            txtTelefone.BackgroundImageLayout = ImageLayout.None;
            txtTelefone.BeepOnError = false;
            txtTelefone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.Depth = 0;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefone.HidePromptOnLeave = false;
            txtTelefone.HideSelection = true;
            txtTelefone.Hint = "Telefone";
            txtTelefone.InsertKeyMode = InsertKeyMode.Default;
            txtTelefone.LeadingIcon = null;
            txtTelefone.Location = new Point(6, 255);
            txtTelefone.Mask = "(00)00000-0000";
            txtTelefone.MaxLength = 32767;
            txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PasswordChar = '\0';
            txtTelefone.PrefixSuffixText = null;
            txtTelefone.PromptChar = '_';
            txtTelefone.ReadOnly = false;
            txtTelefone.RejectInputOnFirstFailure = false;
            txtTelefone.ResetOnPrompt = true;
            txtTelefone.ResetOnSpace = true;
            txtTelefone.RightToLeft = RightToLeft.No;
            txtTelefone.SelectedText = "";
            txtTelefone.SelectionLength = 0;
            txtTelefone.SelectionStart = 0;
            txtTelefone.ShortcutsEnabled = true;
            txtTelefone.Size = new Size(250, 48);
            txtTelefone.SkipLiterals = true;
            txtTelefone.TabIndex = 5;
            txtTelefone.TabStop = false;
            txtTelefone.Text = "(  )     -";
            txtTelefone.TextAlign = HorizontalAlignment.Left;
            txtTelefone.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTelefone.TrailingIcon = null;
            txtTelefone.UseSystemPasswordChar = false;
            txtTelefone.ValidatingType = null;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnNovo);
            materialCard1.Controls.Add(btnSalvar);
            materialCard1.Controls.Add(btnExcluir);
            materialCard1.Controls.Add(btnLocalizar);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(6, 333);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(625, 100);
            materialCard1.TabIndex = 6;
            // 
            // btnLocalizar
            // 
            btnLocalizar.AutoSize = false;
            btnLocalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLocalizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLocalizar.Depth = 0;
            btnLocalizar.HighEmphasis = true;
            btnLocalizar.Icon = null;
            btnLocalizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLocalizar.Location = new Point(429, 26);
            btnLocalizar.Margin = new Padding(0);
            btnLocalizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.NoAccentTextColor = Color.Empty;
            btnLocalizar.Size = new Size(109, 49);
            btnLocalizar.TabIndex = 5;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLocalizar.UseAccentColor = false;
            btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(295, 26);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(108, 49);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(159, 26);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(108, 49);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSize = false;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(27, 26);
            btnNovo.Margin = new Padding(0);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(108, 49);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "NOVO";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // FrmAluno1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(materialCard1);
            Controls.Add(txtTelefone);
            Controls.Add(btnTurmaLista);
            Controls.Add(cboTurma);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Name = "FrmAluno1";
            Text = "FrmAluno1";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCpf;
        private ReaLTaiizor.Controls.MaterialComboBox cboTurma;
        private ReaLTaiizor.Controls.MaterialButton btnTurmaLista;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnLocalizar;
    }
}