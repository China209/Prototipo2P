using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelos
{
    public class clsMaestro
    {
        private int iMaestro;
        private string sNombre;
        private string sApellido;
        private string sDireccion;
        private string sDPI;
        private string sNIT;
        private string sEstatus;

        public int IMaestro { get => iMaestro; set => iMaestro = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SApellido { get => sApellido; set => sApellido = value; }
        public string SDireccion { get => sDireccion; set => sDireccion = value; }
        public string SDPI { get => sDPI; set => sDPI = value; }
        public string SNIT { get => sNIT; set => sNIT = value; }
        public string SEstatus { get => sEstatus; set => sEstatus = value; }
    }
}
