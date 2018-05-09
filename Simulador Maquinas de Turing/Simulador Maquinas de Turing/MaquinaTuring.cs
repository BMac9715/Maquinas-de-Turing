using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class MaquinaTuring
    {
        public Cabezal main;

        public Palindromos p;
        public CopiaPatrones copy;
        public Multiplicacion mult;
        public Suma sum;
        public Resta resta;

        private bool finalizado;
        private bool error;

        public MaquinaTuring()
        {
            main = new Cabezal();

            p = new Palindromos(new string[,] 
            {
                {" ",          "a",      "b",      "c",         "β" },
                {"-> q0", "q1,β,R", "q2,β,R",  "q3,β,R",  "q11,β,L" },
                {"q1",    "q4,a,R", "q4,b,R",  "q4,c,R",  "q11,β,L" },
                {"q2",    "q5,a,R", "q5,b,R",  "q5,c,R",  "q11,β,L" },
                {"q3",    "q6,a,R", "q6,b,R",  "q6,c,R",  "q11,β,L" },
                {"q4",    "q4,a,R", "q4,b,R",  "q4,c,R",   "q7,β,L" },
                {"q5",    "q5,a,R", "q5,b,R",  "q5,c,R",   "q8,β,L" },
                {"q6",    "q6,a,R", "q6,b,R",  "q6,c,R",   "q9,β,L" },
                {"q7",    "q10,β,L",     "-",       "-",        "-" },
                {"q8",           "", "q10,β,L",     "-",        "-" },
                {"q9",          "-",       "-", "q10,β,L",      "-" },
                {"q10",   "q10,a,L", "q10,b,L", "q10,c,L", "q0,β,R" },
                {"* q11",      "-",      "-",      "-",         "-" }
            });
            copy = new CopiaPatrones(new string[,] { });
            mult = new Multiplicacion(new string[,] { });
            sum = new Suma(new string[,] { });
            resta = new Resta(new string[,] { });

            finalizado = false;
            error = false;
        }

        public int CalcularCadena(string cadena, int maquina)
        {
            switch (maquina)
            {
                case 1: return CadenasPalindromos(cadena);
                case 2: return CadenasCopiar(cadena);
                case 3: return CadenasMult(cadena);
                case 4: return CadenasSuma(cadena);
                case 5: return CadenasResta(cadena);
                default: return 0;
            }
        }

        public string PrimerMovimiento(string cadena, int maquina, int pos)
        {
            switch (maquina)
            {
                case 1: return PrimerMovimientoPalindromo(cadena, pos);
                case 2: return PrimerMovimientoCopia(cadena, pos);
                case 3: return PrimerMovimientoMult(cadena, pos);
                case 4: return PrimerMovimientoSum(cadena, pos);
                case 5: return PrimerMovimientoResta(cadena, pos);
                default: return string.Empty;
            }
        }

        public string Movimiento(string cadena, int maquina, int pos)
        {
            switch (maquina)
            {
                case 1: return MovimientoPalindromo(cadena, pos);
                case 2: return MovimientoCopia(cadena, pos);
                case 3: return MovimientoMult(cadena, pos);
                case 4: return MovimientoSum(cadena, pos);
                case 5: return MovimientoResta(cadena, pos);
                default: return string.Empty;
            }          
        }

        private string MovimientoPalindromo(string cadena, int pos){
            int i = pos;
            p.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            p.Cabezal.NuevoCaracter = cinta[i];
            p.Cabezal.Posicion = i;
            p.Movimiento(cinta[i].ToString(), p.Cabezal.Estado);
            cinta[i] = p.Cabezal.NuevoCaracter;

            //Movimiento del cabezal
            if (p.Cabezal.Direccion == 0)
            {
                if (i == 0)
                {
                    cinta.Insert(0, 'β');
                }
                else
                {
                    i--;
                    p.Cabezal.Posicion = i;
                }
            }

            if (p.Cabezal.Direccion == 1)
            {
                if (i == cinta.Count - 1)
                {
                    cinta.Add('β');
                }

                i++;
                p.Cabezal.Posicion = i;
            }

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //asignación de cabezal
            this.main = p.Cabezal;
            this.finalizado = p.Finalizado;
            this.error = p.Error;

            return result;
        }

        private string MovimientoCopia(string cadena, int pos)
        {
            int i = pos;
            copy.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            copy.Cabezal.NuevoCaracter = cinta[i];
            copy.Cabezal.Posicion = i;
            copy.Movimiento(cinta[i].ToString(), copy.Cabezal.Estado);
            cinta[i] = copy.Cabezal.NuevoCaracter;

            //Movimiento del cabezal
            if (copy.Cabezal.Direccion == 0)
            {
                if (i == 0)
                {
                    cinta.Insert(0, 'β');
                }
                else
                {
                    i--;
                    copy.Cabezal.Posicion = i;
                }
            }

            if (copy.Cabezal.Direccion == 1)
            {
                if (i == cinta.Count - 1)
                {
                    cinta.Add('β');
                }

                i++;
                copy.Cabezal.Posicion = i;
            }

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Asignación de Cabezales
            this.main = copy.Cabezal;

            this.finalizado = copy.Finalizado;
            this.error = copy.Error;

            return result;
        }

        private string MovimientoMult(string cadena, int pos)
        {
            int i = pos;
            mult.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            mult.Cabezal.NuevoCaracter = cinta[i];
            mult.Cabezal.Posicion = i;
            mult.Movimiento(cinta[i].ToString(), mult.Cabezal.Estado);
            cinta[i] = mult.Cabezal.NuevoCaracter;

            //Movimiento del cabezal
            if (mult.Cabezal.Direccion == 0)
            {
                if (i == 0)
                {
                    cinta.Insert(0, 'β');
                }
                else
                {
                    i--;
                    mult.Cabezal.Posicion = i;
                }
            }

            if (mult.Cabezal.Direccion == 1)
            {
                if (i == cinta.Count - 1)
                {
                    cinta.Add('β');
                }

                i++;
                mult.Cabezal.Posicion = i;
            }

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Asignación de Cabezales
            this.main = mult.Cabezal;

            this.finalizado = mult.Finalizado;
            this.error = mult.Error;

            return result;
        }

        private string MovimientoSum(string cadena, int pos)
        {
            int i = pos;
            sum.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            sum.Cabezal.NuevoCaracter = cinta[i];
            sum.Cabezal.Posicion = i;
            sum.Movimiento(cinta[i].ToString(), sum.Cabezal.Estado);
            cinta[i] = sum.Cabezal.NuevoCaracter;

            //Movimiento del cabezal
            if (sum.Cabezal.Direccion == 0)
            {
                if (i == 0)
                {
                    cinta.Insert(0, 'β');
                }
                else
                {
                    i--;
                    sum.Cabezal.Posicion = i;
                }
            }

            if (sum.Cabezal.Direccion == 1)
            {
                if (i == cinta.Count - 1)
                {
                    cinta.Add('β');
                }

                i++;
                sum.Cabezal.Posicion = i;
            }

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Asignación de Cabezales
            this.main = sum.Cabezal;

            this.finalizado = sum.Finalizado;
            this.error = sum.Error;

            return result;
        }

        private string MovimientoResta(string cadena, int pos)
        {
            int i = pos;
            resta.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            resta.Cabezal.NuevoCaracter = cinta[i];
            resta.Cabezal.Posicion = i;
            resta.Movimiento(cinta[i].ToString(), resta.Cabezal.Estado);
            cinta[i] = resta.Cabezal.NuevoCaracter;

            //Movimiento del cabezal
            if (resta.Cabezal.Direccion == 0)
            {
                if (i == 0)
                {
                    cinta.Insert(0, 'β');
                }
                else
                {
                    i--;
                    resta.Cabezal.Posicion = i;
                }
            }

            if (resta.Cabezal.Direccion == 1)
            {
                if (i == cinta.Count - 1)
                {
                    cinta.Add('β');
                }

                i++;
                resta.Cabezal.Posicion = i;
            }

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Asignación de Cabezales
            this.main = resta.Cabezal;

            this.finalizado = resta.Finalizado;
            this.error = resta.Error;

            return result;
        }

        private string PrimerMovimientoPalindromo(string cadena, int pos)
        {
            int i = pos;
            p.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial          
            p.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = p.Cabezal.NuevoCaracter;
            i++;
            p.Cabezal.NuevoCaracter = cinta[i];
            p.Cabezal.Posicion = i;

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Alieneación de cabezal
            this.main = p.Cabezal;
            this.finalizado = p.Finalizado;
            this.error = p.Error;

            return result;
        }

        private string PrimerMovimientoCopia(string cadena, int pos)
        {
            int i = pos;
            copy.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial          
            copy.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = copy.Cabezal.NuevoCaracter;
            i++;
            copy.Cabezal.NuevoCaracter = cinta[i];
            copy.Cabezal.Posicion = i;

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            //Alineacion de cabezal
            this.main = copy.Cabezal;
            this.finalizado = copy.Finalizado;
            this.error = copy.Error;

            return result;
        }

        private string PrimerMovimientoMult(string cadena, int pos)
        {
            int i = pos;
            mult.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial          
            mult.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = mult.Cabezal.NuevoCaracter;
            i++;
            mult.Cabezal.NuevoCaracter = cinta[i];
            mult.Cabezal.Posicion = i;

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            this.main = mult.Cabezal;
            this.finalizado = mult.Finalizado;
            this.error = mult.Error;

            return result;
        }

        private string PrimerMovimientoSum(string cadena, int pos)
        {
            int i = pos;
            sum.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial          
            sum.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = sum.Cabezal.NuevoCaracter;
            i++;
            sum.Cabezal.NuevoCaracter = cinta[i];
            sum.Cabezal.Posicion = i;

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            this.main = sum.Cabezal;
            this.finalizado = sum.Finalizado;
            this.error = sum.Error;

            return result;
        }

        private string PrimerMovimientoResta(string cadena, int pos)
        {
            int i = pos;
            resta.Cabezal.Posicion = i;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial          
            resta.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = resta.Cabezal.NuevoCaracter;
            i++;
            resta.Cabezal.NuevoCaracter = cinta[i];
            resta.Cabezal.Posicion = i;

            //Escribir la cadena de salida
            string result = string.Empty;

            foreach (var element in cinta)
            {
                result += element.ToString();
            }

            this.main = resta.Cabezal;
            this.finalizado = resta.Finalizado;
            this.error = resta.Finalizado;

            return result;
        }

        private int CadenasPalindromos(string cadena)
        {
            int i = 0;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial
            p.Cabezal.Posicion = i;
            p.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = p.Cabezal.NuevoCaracter;
            i++;

            while (!p.Error && !p.Finalizado)
            {
                p.Cabezal.NuevoCaracter = cinta[i];
                p.Cabezal.Posicion = i;
                p.Movimiento(cinta[i].ToString(), p.Cabezal.Estado);
                cinta[i] = p.Cabezal.NuevoCaracter;

                //Movimiento del cabezal
                if (p.Cabezal.Direccion == 0)
                {
                    if (i == 0)
                    {
                        cinta.Insert(0, 'β');
                    }
                    else
                    {
                        i--;
                        p.Cabezal.Posicion = i;
                    }
                }

                if (p.Cabezal.Direccion == 1)
                {
                    if (i == cinta.Count - 1)
                    {
                        cinta.Add('β');
                    }

                    i++;
                    p.Cabezal.Posicion = i;
                }
            }

            /*
            //Escribir la cadena de salida
            string result = string.Empty;

            foreach(var element in cinta)
            {
                result += element.ToString();
            }
            */
            p.Finalizado = false;

            return cinta.Count;
        }
    
        private int CadenasCopiar(string cadena)
        {
            int i = 0;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial
            copy.Cabezal.Posicion = i;
            copy.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = copy.Cabezal.NuevoCaracter;
            i++;

            while (!copy.Error && !copy.Finalizado)
            {
                copy.Cabezal.NuevoCaracter = cinta[i];
                copy.Cabezal.Posicion = i;
                copy.Movimiento(cinta[i].ToString(), copy.Cabezal.Estado);
                cinta[i] = copy.Cabezal.NuevoCaracter;

                //Movimiento del cabezal
                if (copy.Cabezal.Direccion == 0)
                {
                    if (i == 0)
                    {
                        cinta.Insert(0, 'β');
                    }
                    else
                    {
                        i--;
                        copy.Cabezal.Posicion = i;
                    }
                }

                if (copy.Cabezal.Direccion == 1)
                {
                    if (i == cinta.Count - 1)
                    {
                        cinta.Add('β');
                    }

                    i++;
                    copy.Cabezal.Posicion = i;
                }
            }

            copy.Finalizado = false;

            return cinta.Count;
        }

        private int CadenasMult(string cadena)
        {
            int i = 0;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial
            mult.Cabezal.Posicion = i;
            mult.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = mult.Cabezal.NuevoCaracter;
            i++;

            while (!mult.Error && !mult.Finalizado)
            {
                mult.Cabezal.NuevoCaracter = cinta[i];
                mult.Cabezal.Posicion = i;
                mult.Movimiento(cinta[i].ToString(), mult.Cabezal.Estado);
                cinta[i] = mult.Cabezal.NuevoCaracter;

                //Movimiento del cabezal
                if (mult.Cabezal.Direccion == 0)
                {
                    if (i == 0)
                    {
                        cinta.Insert(0, 'β');
                    }
                    else
                    {
                        i--;
                        mult.Cabezal.Posicion = i;
                    }
                }

                if (mult.Cabezal.Direccion == 1)
                {
                    if (i == cinta.Count - 1)
                    {
                        cinta.Add('β');
                    }

                    i++;
                    mult.Cabezal.Posicion = i;
                }
            }

            mult.Finalizado = false;

            return cinta.Count;
        }

        private int CadenasSuma(string cadena)
        {
            int i = 0;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial
            sum.Cabezal.Posicion = i;
            sum.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = sum.Cabezal.NuevoCaracter;
            i++;

            while (!sum.Error && !sum.Finalizado)
            {
                sum.Cabezal.NuevoCaracter = cinta[i];
                sum.Cabezal.Posicion = i;
                sum.Movimiento(cinta[i].ToString(), sum.Cabezal.Estado);
                cinta[i] = sum.Cabezal.NuevoCaracter;

                //Movimiento del cabezal
                if (sum.Cabezal.Direccion == 0)
                {
                    if (i == 0)
                    {
                        cinta.Insert(0, 'β');
                    }
                    else
                    {
                        i--;
                        sum.Cabezal.Posicion = i;
                    }
                }

                if (sum.Cabezal.Direccion == 1)
                {
                    if (i == cinta.Count - 1)
                    {
                        cinta.Add('β');
                    }

                    i++;
                    sum.Cabezal.Posicion = i;
                }
            }

            sum.Finalizado = false;

            return cinta.Count;
        }

        private int CadenasResta(string cadena)
        {
            int i = 0;
            List<char> cinta = cadena.ToCharArray().ToList();

            //Movimiento Inicial
            resta.Cabezal.Posicion = i;
            resta.Movimiento(cinta[i].ToString(), 0);
            cinta[i] = resta.Cabezal.NuevoCaracter;
            i++;

            while (!resta.Error && !resta.Finalizado)
            {
                resta.Cabezal.NuevoCaracter = cinta[i];
                resta.Cabezal.Posicion = i;
                resta.Movimiento(cinta[i].ToString(), resta.Cabezal.Estado);
                cinta[i] = resta.Cabezal.NuevoCaracter;

                //Movimiento del cabezal
                if (resta.Cabezal.Direccion == 0)
                {
                    if (i == 0)
                    {
                        cinta.Insert(0, 'β');
                    }
                    else
                    {
                        i--;
                        resta.Cabezal.Posicion = i;
                    }
                }

                if (resta.Cabezal.Direccion == 1)
                {
                    if (i == cinta.Count - 1)
                    {
                        cinta.Add('β');
                    }

                    i++;
                    resta.Cabezal.Posicion = i;
                }
            }

            resta.Finalizado = false;

            return cinta.Count;
        }

        public bool Finalizado { get => finalizado; set => finalizado = value; }

        public bool Error { get => error; set => error = value; }
    }
}
