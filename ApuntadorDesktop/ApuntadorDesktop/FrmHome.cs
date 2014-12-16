using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Windows.Forms.Integration;

namespace ApuntadorDesktop
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //este metodo va a pedir a la base de datos o a algun lado si hay apuntes creados
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                flpContenedorTarjetas = new FlowLayoutPanel();
                TarjetaApunte unaTarjeta = new TarjetaApunte();
                foreach (Control unControl in unaTarjeta.Controls)
                {
                    if (unControl is RichTextBox)
                    {
                        unControl.Text = "A mira vos que buena onda";
                    }
                    else if (unControl is Label) {
                        unControl.Text = "Hu pero que masa!";
                    }

                }
                this.flpContenedorTarjetas.Controls.Add(unaTarjeta);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void nuevoApunteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNuevoApunte = new FrmApunte();
            formNuevoApunte.Show(this);
            
        }
    }
}