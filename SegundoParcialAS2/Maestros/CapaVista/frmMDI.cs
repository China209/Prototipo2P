using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void datosDeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestros maestros = new frmMaestros();
            maestros.Show();
        }

        private void telefonosDeMestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTelefonos telefonos = new frmTelefonos();
            telefonos.Show();
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
