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
    public partial class frmTelefonos : Form
    {
        private clsTelefonos modulo;
        private string sTelefono;
        private int iIDAux;
        private clsControladorTelefono controlModulo = new clsControladorTelefono();

        public frmTelefonos()
        {
            InitializeComponent();
            cargarDatos();
            CargarCombobox();
            BloquearBotones();
        }

        private void CargarCombobox()
        {
            cmbMaestro.DisplayMember = "nombre_maestro";
            cmbMaestro.ValueMember = "codigo_maestro";
            cmbMaestro.DataSource = controlModulo.obtenerCamposCombobox("codigo_maestro", "nombre_maestro","maestro","estatus_maestro");
            cmbMaestro.SelectedIndex = -1;
            cmbMaestro.Refresh();
            cmbBuscar.DisplayMember = "nombre_maestro";
            cmbBuscar.ValueMember = "codigo_registro";
            cmbBuscar.DataSource = controlModulo.obtenerCamposCombobox("t.codigo_registro", "m.nombre_maestro", "maestro m, telefono_maestro t", "m.codigo_maestro=t.codigo_maestro AND t.estatus_telefono");
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
            cmbMaestro.Enabled = true;
        }
        private clsTelefonos llenarCampos()
        {
            clsTelefonos auxModulo = new clsTelefonos();
            auxModulo.IMaestro = int.Parse(cmbMaestro.SelectedValue.ToString());
            auxModulo.STelefon = txtTelefono.Text;
            auxModulo.SEstatus = "1";
            return auxModulo;
        }

        private void LimpiarComponentes()
        {
            cmbMaestro.SelectedIndex = -1;
            txtTelefono.Text = "";
            cmbMaestro.Focus();
        }
        private clsTelefonos ObtenerModificaciones()
        {
            clsTelefonos auxModulo = new clsTelefonos();
            auxModulo.STelefon = txtTelefono.Text;
            auxModulo.ICodigo = iIDAux;
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
                iIDAux = int.Parse(dgvVistaDatos.Rows[e.RowIndex].Cells["codigo_registro"].Value.ToString());
                sTelefono = dgvVistaDatos.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
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
            txtTelefono.Text = sTelefono;
            cmbMaestro.Enabled = false;
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
