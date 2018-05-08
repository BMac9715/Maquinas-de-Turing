using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Maquinas_de_Turing
{
    public class MaquinaTuring
    {

        public MaquinaTuring()
        {

        }

        public string CalcularCadena(int maquina, string cadena)
        {
            string cinta = string.Empty;

            switch (maquina)
            {
                case 1:
                    cinta = cadena;
                    break;
            }

            return cinta;
        }
    
    }
}
