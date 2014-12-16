using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApuntadorDesktop
{
    public partial class FrmApunte : Form
    {
        public FrmApunte()
        {
            InitializeComponent();
        }

        private void btnSlider_Click(object sender, EventArgs e)
        {
            tm.Enabled = true;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (pnlSlider.Height == 0) tm.Enabled = false;
            else pnlSlider.Height = -12;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ah mira");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hu mura");
        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {
            tscContenedorToolstrip.Enabled = true;
        }
    }
}
