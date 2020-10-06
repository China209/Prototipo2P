using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
using CapaModelo.Modelos;

namespace CapaVista
{
    public partial class frmMaestros : Form
    {
        private clsMaestro modulo;
        private string sNombreAux, sApeAux,sDirAux,sDPIAux,sNitAux;
        private int iIDAux;
        private clsControlMaestro controlModulo = new clsControlMaestro();

        public frmMaestros()
        {
            InitializeComponent();
            cargarDatos();
            CargarCombobox();
            BloquearBotones();
        }

        private void CargarCombobox()
        {
            cmbBuscar.DisplayMember = "nombre_maestro";
            cmbBuscar.ValueMember = "codigo_maestro";
            cmbBuscar.DataSource = controlModulo.obtenerCamposCombobox();
            cmbBuscar.SelectedIndex = -1;
            cmbBuscar.Refresh();
        }
        private void cargarDatos()
        {
            dgvVistaDatos.DataSource = controlModulo.obtenerTodo();
        }
        private void BloquearBotones()
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
        }
        private clsMaestro llenarCampos()
        {
            clsMaestro auxModulo = new clsMaestro();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SApellido = txtApellido.Text;
            auxModulo.SDireccion = txtDireccion.Text;
            auxModulo.SDPI = txtDPI.Text;
            auxModulo.SNIT = txtNIT.Text;
            auxModulo.SEstatus = "1";
            return auxModulo;
        }

        private void LimpiarComponentes()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDPI.Text = "";
            txtNIT.Text = "";
            txtNombre.Focus();
        }
        private clsMaestro ObtenerModificaciones()
        {
            clsMaestro auxModulo = new clsMaestro();
            auxModulo.SNombre = txtNombre.Text;
            auxModulo.SApellido = txtApellido.Text;
            auxModulo.SDireccion = txtDireccion.Text;
            auxModulo.SDPI = txtDPI.Text;
            auxModulo.SNIT = txtNIT.Text;
            auxModulo.IMaestro = iIDAux;
            return auxModulo;
        }

        private bool guardarDatos()
        {
            this.modulo = llenarCampos();
            try
            {
                controlModulo.insertarReportes(this.modulo);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Guardados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Guardar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardarDatos() == true)
            {
                LimpiarComponentes();
            }
            else
            {
                LimpiarComponentes();
            }
        }
        private bool ModificarDatos()
        {
            this.modulo = ObtenerModificaciones();
            try
            {
                controlModulo.modificarReportes(this.modulo);
                cargarDatos();
                MessageBox.Show("Datos Correctamente Modificados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        private void dgvVistaDatos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["codigo_maestro"].Value.ToString());
                sNombreAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nombre_maestro"].Value.ToString();
                sApeAux = dgvVistaDatos.Rows[e.RowIndex].Cells["apellido_maestro"].Value.ToString();
                sDirAux = dgvVistaDatos.Rows[e.RowIndex].Cells["direccion_maestro"].Value.ToString();
                sDPIAux = dgvVistaDatos.Rows[e.RowIndex].Cells["dpi_maestro"].Value.ToString();
                sNitAux = dgvVistaDatos.Rows[e.RowIndex].Cells["nit_maestro"].Value.ToString();
                this.cmsEM.Show(this.dgvVistaDatos, e.Location);
                cmsEM.Show(Cursor.Position);
            }
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dgMensaje = MessageBox.Show("Una vez eliminado estos datos no se podrán recuperar, ¿Desea Continuar?", "¡ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dgMensaje == DialogResult.Yes)
                {
                    this.controlModulo.eliminarReportes(iIDAux);
                    cargarDatos();
                    MessageBox.Show("Datos Correctamente Eliminados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (dgMensaje == DialogResult.No)
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar los Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void cmsModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            txtNombre.Text = sNombreAux;
            txtApellido.Text = sApeAux;
            txtDireccion.Text = sDirAux;
            txtDPI.Text = sDPIAux;
            txtNIT.Text = sNitAux;
        }

        private void tmrHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmModulo_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex >= 0)
            {
                int iIDAux = int.Parse(cmbBuscar.SelectedValue.ToString());
                dgvVistaDatos.DataSource = controlModulo.obtenerDatos(iIDAux);
            }
            else if (cmbBuscar.SelectedIndex < 0)
            {
                cargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ModificarDatos() == true)
            {
                LimpiarComponentes();
                BloquearBotones();
            }
            else
            {
                LimpiarComponentes();
                BloquearBotones();
            }
        }
    }
}
