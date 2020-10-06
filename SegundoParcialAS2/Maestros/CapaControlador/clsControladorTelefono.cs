using CapaModelo;
using CapaModelo.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador
{
    public class clsControladorTelefono
    {
        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        DataTable tabla;
        OdbcDataAdapter datos;
        public void insertarReportes(clsTelefonos maestro)
        {
            try
            {
                string sComando = string.Format("INSERT INTO telefono_maestro(codigo_maestro,telefono, estatus_telefono) VALUES ({0},'{1}','{2}');", maestro.IMaestro, maestro.STelefon, maestro.SEstatus);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
        public void modificarReportes(clsTelefonos maestro)
        {
            try
            {
                string sComando = string.Format("UPDATE telefono_maestro SET telefono='{1}' WHERE codigo_registro={0};", maestro.ICodigo, maestro.STelefon);
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
                string sComando = string.Format("UPDATE telefono_maestro SET estatus_telefono=0 WHERE codigo_registro={0};", iMaestro.ToString());
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
                string sComando = string.Format("SELECT codigo_registro,codigo_maestro,telefono FROM telefono_maestro WHERE estatus_telefono=1");
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
                string sComando = string.Format("SELECT codigo_registro,codigo_maestro,telefono FROM telefono_maestro WHERE estatus_telefono=1 AND codigo_registro={0};", iMaestro.ToString());
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
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstaus )
        {
            try
            {
                string sComando = string.Format("SELECT "+sCampo1+","+sCampo2 +" FROM "+sTabla+" WHERE "+sEstaus+"=1");
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
