using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class Multiplicacion
    {
        private string[,] transiciones;
        private bool error;
        private bool finalizado;
        private Cabezal cabezal;

        public Multiplicacion(string[,] tablaDeTransiciones)
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
                case 8: Q8(caracter); break;
                case 9: Q9(caracter); break;
                case 10: Q10(caracter); break;
                case 11: Q11(caracter); break;
                case 12: Q12(caracter); break;
                case 13: Q13(caracter); break;
                case 14: Q14(caracter); break;
                case 15: Q15(caracter); break;
                case 16: Q16(caracter); break;
                case 17: Q17(caracter); break;
            }
        }

        public void Q0(string caracter)
        {
            switch (caracter)
            {
                case "*":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 17;
                    break;
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 14;
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
                case "1":
                    cabezal.NuevoCaracter = 'z';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 4;
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
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 2;
                    break;
                case "β":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 3;
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
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 3;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 3;
                    break;
                case "z":
                    cabezal.NuevoCaracter = 'z';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
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
                case "z":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 4;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 5;
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
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 7;
                    break;
                case "*":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 13;
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
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 1;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q7(string caracter)
        {
            switch (caracter)
            {
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 8;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q8(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 9;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 10;
                    break;            
                default:
                    error = true;
                    break;
            }
        }

        public void Q9(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 9;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 16;
                    break;
                default:
                    error = true;
                    break;
            }
        }
            
        public void Q10(string caracter)
        {
            switch (caracter)
            {
                case "*":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 11;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q11(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 11;
                    break;
                case "*":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 12;
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
        public void Q12(string caracter)
        {
            this.finalizado = true;
        }

        public void Q13(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 13;
                    break;
                case "*":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 13;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 12;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q14(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 14;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 14;
                    break;
                case "β":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 15;
                    break;
                default:
                    error = true;
                    break;
            }
        }
        
        public void Q15(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = '1';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 15;
                    break;
                case "*":
                    cabezal.NuevoCaracter = '*';
                    cabezal.Direccion = 0;
                    cabezal.Estado = 15;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 16;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q16(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 6;
                    break;
                default:
                    error = true;
                    break;
            }
        }

        public void Q17(string caracter)
        {
            switch (caracter)
            {
                case "1":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 17;
                    break;
                case "β":
                    cabezal.NuevoCaracter = 'β';
                    cabezal.Direccion = 1;
                    cabezal.Estado = 12;
                    break;
                default:
                    error = true;
                    break;
            }
        }

    }
}
