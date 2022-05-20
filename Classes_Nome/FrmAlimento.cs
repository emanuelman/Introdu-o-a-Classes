using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Nome
{
    public partial class FrmAlimento : Form
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }

        private void frmLojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja frm = new FrmLoja(); // indica qual form será aberto
            this.Hide(); // fecha o autual
            frm.ShowDialog();
        }

        private void frmAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento frm = new FrmAlimento(); // indica qual form será aberto
            this.Hide(); // fecha o autual
            frm.ShowDialog();
        }

        private void frmPrefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito frm = new FrmPrefeito(); // indica qual form será aberto
            this.Hide(); // fecha o autual
            frm.ShowDialog();
        }
    }
}
