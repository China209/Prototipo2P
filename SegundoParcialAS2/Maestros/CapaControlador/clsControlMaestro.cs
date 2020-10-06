using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using CapaModelo.Modelos;

namespace CapaControlador
{
    public class clsControlMaestro
    {
        clsSentencia sentencia=new clsSentencia();
        clsConexion conexion = new clsConexion();
        DataTable tabla;
        OdbcDataAdapter datos;
        public void insertarReportes(clsMaestro maestro)
        {
            try
            {
                string sComando = string.Format("INSERT INTO maestro(nombre_maestro, apellido_maestro,direccion_maestro,dpi_maestro,nit_maestro, estatus_maestro) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", maestro.SNombre,maestro.SApellido,maestro.SDireccion,maestro.SDPI,maestro.SNIT,maestro.SEstatus);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
        public void modificarReportes(clsMaestro maestro)
        {
            try
            {
                string sComando = string.Format("UPDATE maestro SET nombre_maestro='{1}', apellido_maestro='{2}',direccion_maestro='{3}', dpi_maestro='{4}', nit_maestro='{4}' WHERE codigo_maestro={0};", maestro.IMaestro,maestro.SNombre,maestro.SApellido,maestro.SDireccion,maestro.SDPI,maestro.SNIT);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public void eliminarReportes(int iMaestro)
        {
            try
            {
                string sComando = string.Format("UPDATE maestro SET estatus_maestro=0 WHERE codigo_maestro={0};", iMaestro.ToString());
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable obtenerTodo()
        {
            try
            {
                string sComando = string.Format("SELECT codigo_maestro, nombre_maestro, apellido_maestro,direccion_maestro,dpi_maestro,nit_maestro FROM maestro WHERE estatus_maestro=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable obtenerDatos(int iMaestro)
        {
            try
            {
                string sComando = string.Format("SELECT codigo_maestro, nombre_maestro, apellido_maestro,direccion_maestro,dpi_maestro,nit_maestro FROM maestro WHERE estatus_maestro=1 AND codigo_maestro={0};", iMaestro.ToString());
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable obtenerCamposCombobox()
        {
            try
            {
                string sComando = string.Format("SELECT codigo_maestro, nombre_maestro FROM maestro WHERE estatus_maestro=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
