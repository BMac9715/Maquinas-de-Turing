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

            foreach(var element in cinta)
            {
                result += element.ToString();
            }

            return result;
        }

        public string Movimiento(string cadena, int maquina, int pos)
        {
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

            return cinta.Count;
        }
    
        private int CadenasCopiar(string cadena)
        {
            return 0;
        }

        private int CadenasMult(string cadena)
        {
            return 0;
        }

        private int CadenasSuma(string cadena)
        {
            return 0;
        }

        private int CadenasResta(string cadena)
        {
            return 0;
        }
    }
}
