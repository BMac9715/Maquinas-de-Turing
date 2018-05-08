using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class Cabezal
    {
        private int direccion;
        private int estado;
        private string caracter;
        private string nuevoCaracter;

        /// <summary>
        /// Constructor
        /// </summary>
        public Cabezal()
        {

        }

        public int Direccion { get => direccion; set => direccion = value; }
        public string Caracter { get => caracter; set => caracter = value; }
        public string NuevoCaracter { get => nuevoCaracter; set => nuevoCaracter = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
