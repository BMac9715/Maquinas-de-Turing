using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class Palindromos
    {
        private string[,] transiciones;
        private bool error;
        private bool finalizado;
        private Cabezal cabezal;

        public Palindromos(string[,] tablaDeTransiciones)
        {
            this.transiciones = tablaDeTransiciones;
            this.error = false;
            this.finalizado = false;
            this.cabezal = new Cabezal();
        }

        public string[,] Transiciones { get => transiciones; set => transiciones = value; }

        public bool Error { get => error; set => error = value; }

        public Cabezal Cabezal { get => cabezal; set => cabezal = value; }
        public bool Finalizado { get => finalizado; set => finalizado = value; }

        /// <summary>
        /// Ejecuta un movimiento en la maquina de turing
        /// </summary>
        /// <param name="caracter"></param>
        /// <param name="estado"></param>
        public void Movimiento(string caracter, int estado)
        {
            switch(estado)
            {
                case 0: Q0(caracter);   break;
                case 1: Q1(caracter);   break;
                case 2: Q2(caracter);   break;
                case 3: Q3(caracter);   break;
                case 4: Q4(caracter);   break;
                case 5: Q5(caracter);   break;
                case 6: Q6(caracter);   break;
                case 7: Q7(caracter);   break;
                case 8: Q8(caracter);   break;
                case 9: Q9(caracter);   break;
                case 10: Q10(caracter); break;
                case 11: Q11(caracter); break;
            }
        }

        /// <summary>
        /// Estado de transición q0
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private void Q0(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 11;
                    break;

                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q1
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q1(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 11;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q2
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q2(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 11;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q3
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q3(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 11;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q4
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q4(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 7;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q5
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q5(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 8;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transicipon q6
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q6(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 9;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q7
        /// </summary>
        /// <param name="caracter"></param>
        public void Q7(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q8
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q8(string caracter)
        {
            switch (caracter)
            {
                case "b":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q9
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public void Q9(string caracter)
        {
            switch (caracter)
            {
                case "c":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de transición q10
        /// </summary>
        /// <param name="caracter"></param>
        public void Q10(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 10;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 0;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        /// <summary>
        /// Estado de aceptación
        /// </summary>
        /// <param name="caracter"></param>
        public void Q11(string caracter)
        {
            this.finalizado = true;
        }
    }
}
