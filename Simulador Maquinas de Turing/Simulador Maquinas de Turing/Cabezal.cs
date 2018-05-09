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
        private char nuevoCaracter;
        private int posicion;

        /// <summary>
        /// Constructor
        /// </summary>
        public Cabezal()
        {
            this.direccion = 0;
            this.estado = 0;
            this.posicion = 0;
            this.caracter = "a";
            this.nuevoCaracter = 'a';
        }

        public int Direccion { get => direccion; set => direccion = value; }
        public string Caracter { get => caracter; set => caracter = value; }   
        public int Estado { get => estado; set => estado = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public char NuevoCaracter { get => nuevoCaracter; set => nuevoCaracter = value; }
    }
}
