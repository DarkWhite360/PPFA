using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    public partial class FrmMovimentacao : Form
    {
        public FrmMovimentacao()
        {
            InitializeComponent();
        }

        private void txtDataPagamento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
