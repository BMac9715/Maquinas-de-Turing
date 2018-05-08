using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Maquinas_de_Turing
{
    public partial class Form1 : Form
    {
        MaquinaTuring maquinas;

        public Form1()
        {
            InitializeComponent();
            IniciarPicturesBox();
            DeshabilitarBotones();
            trackBar1.Value = 2;


            maquinas = new MaquinaTuring();
        }

        private void IniciarPicturesBox()
        {
            Bitmap b = new Bitmap(pB1.Width, pB1.Height);
            pB1.Image = (Image)b;
            pB2.Image = b;
            pB3.Image = b;
            pB4.Image = b;
            pB5.Image = b;
            pB6.Image = b;
            pB7.Image = b;
            pB8.Image = b;
            pB9.Image = b;
            pB10.Image = b;
            pB11.Image = b;
            pB12.Image = b;
            pB13.Image = b;
            pB14.Image = b;
            pB15.Image = b;
            pB16.Image = b;
            pB17.Image = b;

            Graphics g = Graphics.FromImage(b);
            g.DrawString("β", new Font("Arial", 25), Brushes.Black, new Point(6, 4));

            //PictureBox de estado
            pBCabezal.Image = Properties.Resources.cabezal;
            //PictureBox del cabezal
            pBEstado.Image = Properties.Resources.circulo_amarillo;
            g = Graphics.FromImage(pBEstado.Image);
            g.DrawString("q0", new Font("Arial", 25), Brushes.Black, new Point(10, 12));

            //Fondo del PictureBox Inicial
            pB1.BackColor = Color.LightGreen;
            
        }

        private void DeshabilitarBotones()
        {
            btnRun.Enabled = false;
            btnPausa.Enabled = false;
            btnReiniciar.Enabled = false;
            btnPaso.Enabled = false;
        }

        private void MoverCabezal(int direccion)
        {
            //Izquierda -> 0
            //Derecha -> 1

            switch (direccion)
            {
                case 0:
                    if(pBCabezal.Location.X > 19)
                    {
                        pBCabezal.Location = new Point(pBCabezal.Location.X - 51, pBCabezal.Location.Y);
                    }       
                    break;
                case 1:
                    if(pBCabezal.Location.X < 835)
                    {
                        pBCabezal.Location = new Point(pBCabezal.Location.X + 51, pBCabezal.Location.Y);
                    }                 
                    break;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;

            if(cadena == "")
            {
                maquinas.CalcularCadena(1, cadena);   
            }
            else
            {
                MessageBox.Show("No puede ingresar la cadena vacia.", "Información", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PintarCinta(string cinta)
        {

        }
    }
}
