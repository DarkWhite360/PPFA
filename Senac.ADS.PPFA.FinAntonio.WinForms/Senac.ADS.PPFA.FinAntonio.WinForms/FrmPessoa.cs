using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    public partial class FrmPessoa : Form
    {
        public FrmPessoa()
        {
            InitializeComponent();
        }

        private void txtComplemento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
