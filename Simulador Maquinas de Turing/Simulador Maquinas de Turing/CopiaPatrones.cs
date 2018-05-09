using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class CopiaPatrones
    {
        private string[,] transiciones;
        private bool error;
        private bool finalizado;
        private Cabezal cabezal;

        public CopiaPatrones(string[,] tablaDeTransiciones)
        {
            this.transiciones = tablaDeTransiciones;
            this.error = false;
            this.finalizado = false;
            this.cabezal = new Cabezal();
        }

        public string[,] Transiciones { get => transiciones; set => transiciones = value; }
        public bool Error { get => error; set => error = value; }
        public bool Finalizado { get => finalizado; set => finalizado = value; }
        public Cabezal Cabezal { get => cabezal; set => cabezal = value; }

        public void Movimiento(string caracter, int estado)
        {
            switch (estado)
            {
                case 0: Q0(caracter); break;
                case 1: Q1(caracter); break;
                case 2: Q2(caracter); break;
                case 3: Q3(caracter); break;
                case 4: Q4(caracter); break;
                case 5: Q5(caracter); break;
                case 6: Q6(caracter); break;
                case 7: Q7(caracter); break;
            }
        }

        public void Q0(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "A":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q1(string caracter)
        {
            switch (caracter)
            {             
                case "A":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
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

        public void Q2(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "A":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;

                default:
                    error = true;
                    break;
            }
        }

        public void Q3(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "A":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 3;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;

                default:
                    error = true;
                    break;
            }   
        }

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
                case "A":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 0;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 0;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 0;
                    break;
                default:
                    error = true;
                    break;
            }
        }

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
                case "A":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;

                default:
                    error = true;
                    break;
            }
        }

        public void Q6(string caracter)
        {
            switch (caracter)
            {
                case "a":
                    cabezal.NuevoCaracter = 'a';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "b":
                    cabezal.NuevoCaracter = 'b';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "c":
                    cabezal.NuevoCaracter = 'c';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "A":
                    cabezal.NuevoCaracter = 'A';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "B":
                    cabezal.NuevoCaracter = 'B';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "C":
                    cabezal.NuevoCaracter = 'C';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 6;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 4;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q7(string caracter)
        {
            this.finalizado = true;
        }

    }
}
