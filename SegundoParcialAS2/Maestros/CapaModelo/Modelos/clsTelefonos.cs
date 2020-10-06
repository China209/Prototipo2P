using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Modelos
{
    public class clsTelefonos
    {
        private int iCodigo;
        private int iMaestro;
        private string sTelefon;
        private string sEstatus;

        public int ICodigo { get => iCodigo; set => iCodigo = value; }
        public int IMaestro { get => iMaestro; set => iMaestro = value; }
        public string STelefon { get => sTelefon; set => sTelefon = value; }
        public string SEstatus { get => sEstatus; set => sEstatus = value; }
    }
}
