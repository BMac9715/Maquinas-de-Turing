using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class MaquinaTuring
    {
        private string nombre;
        private string[] estados;
        private string[,] tablaDeTransiciones;
        private string[] alfabetoEntrada;
        private string[] alfabetoCinta;
        private string estadoInicial;
        private string[] estadosFinales;
        private string blanco;

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public MaquinaTuring()
        {

        }

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estados"></param>
        /// <param name="tablaDeTransiciones"></param>
        /// <param name="alfabetoEntrada"></param>
        /// <param name="alfabetoCinta"></param>
        /// <param name="estadoInicial"></param>
        /// <param name="estadosFinales"></param>
        /// <param name="blanco"></param>
        public MaquinaTuring(string nombre, string[] estados, string[,] tablaDeTransiciones, 
                             string[] alfabetoEntrada, string[] alfabetoCinta, string estadoInicial,
                             string[] estadosFinales, string blanco)
        {
            this.Nombre = nombre;
            this.Estados = estados;
            this.TablaDeTransiciones = tablaDeTransiciones;
            this.AlfabetoEntrada = alfabetoEntrada;
            this.AlfabetoCinta = alfabetoCinta;
            this.EstadoInicial = estadoInicial;
            this.EstadosFinales = estadosFinales;
            this.Blanco = blanco;
        }


        //Get's and Set's
        public string Nombre { get => nombre; set => nombre = value; }
        public string[] Estados { get => estados; set => estados = value; }
        public string[,] TablaDeTransiciones { get => tablaDeTransiciones; set => tablaDeTransiciones = value; }
        public string[] AlfabetoEntrada { get => alfabetoEntrada; set => alfabetoEntrada = value; }
        public string[] AlfabetoCinta { get => alfabetoCinta; set => alfabetoCinta = value; }
        public string EstadoInicial { get => estadoInicial; set => estadoInicial = value; }
        public string[] EstadosFinales { get => estadosFinales; set => estadosFinales = value; }
        public string Blanco { get => blanco; set => blanco = value; }
    }
}
