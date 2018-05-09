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
        int pasos;
        int posicionCabezal;
        int inicio;
        int fin;
        int maquina;
        string cadenaInicial;
        string cinta;
        bool primero;

        public Form1()
        {
            InitializeComponent();
            IniciarPicturesBox();
            DeshabilitarBotones();      
            trackBar1.Value = 2;
            dgvCinta.Rows.Add();
            IniciarCinta();
            rbtnPalindromos.Checked = true;

            maquinas = new MaquinaTuring();
            posicionCabezal = 0;
            pasos = 0;
            inicio = 0;
            fin = 21;
            maquina = 0;
            primero = false;
        }

        private void IniciarPicturesBox()
        {
            //PictureBox de estado
            pBCabezal.Image = Properties.Resources.cabezal;
            //PictureBox del cabezal
            pBEstado.Image = Properties.Resources.circulo_amarillo;
            Graphics g = Graphics.FromImage(pBEstado.Image);
            g.DrawString("q0", new Font("Arial", 22), Brushes.Black, new Point(10, 12));
            
        }

        private void DeshabilitarBotones()
        {
            btnRun.Enabled = false;
            btnPausa.Enabled = false;
            btnReiniciar.Enabled = false;
            btnPaso.Enabled = false;
        }

        private void ActivarBotones()
        {
            btnRun.Enabled = true;
            btnPaso.Enabled = true;
        }

        private void IniciarCinta()
        {
            for(int i = 0; i < dgvCinta.ColumnCount; i++)
            {
                dgvCinta[i,0].Value = "β";
            }
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
                        pBCabezal.Location = new Point(pBCabezal.Location.X - 40, pBCabezal.Location.Y);
                        dgvCinta[posicionCabezal + 1, 0].Style.BackColor = Color.White;
                        dgvCinta[posicionCabezal, 0].Style.BackColor = Color.LightYellow;
                    }       
                    break;
                case 1:
                    if(pBCabezal.Location.X < 835)
                    {
                        pBCabezal.Location = new Point(pBCabezal.Location.X + 40, pBCabezal.Location.Y);
                        dgvCinta[posicionCabezal - 1, 0].Style.BackColor = Color.White;
                        dgvCinta[posicionCabezal, 0].Style.BackColor = Color.LightYellow;
                    }                 
                    break;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            pasos = 0;
            cinta = string.Empty;
            string cadena = txtCadena.Text;

            if(rbtnPalindromos.Checked == true) { maquina = 1; }
            else if (rbtnCopiar.Checked == true) { maquina = 2; }
            else if (rbtnMult.Checked == true) { maquina = 3; }
            else if (rbtnSuma.Checked == true) { maquina = 4; }
            else if (rbtnResta.Checked == true) { maquina = 5; }

            if (cadena != "")
            {
                int longitud = maquinas.CalcularCadena(cadena, maquina);
                maquinas.p.Error = false;
                maquinas.p.Finalizado = false;

                if (cadena.Length <= 20)
                {
                    cinta = "β" + cadena;
                    for (int i = cinta.Length; i <= 21; i++)
                    {
                            cinta += "β";
                    }          
                }
                else {
                    cinta = "β"+ cadena;
                    inicio = 0;
                    fin = 21;
                }

                //Establecer posicion del cabezal
                pBCabezal.Location = new Point(62, pBCabezal.Location.Y);

                //Ingresar cadena a la cinta
                PintarCinta(cinta);

                //Reacomodamiento del cabezal
                posicionCabezal = 1;
                dgvCinta[posicionCabezal, 0].Style.BackColor = Color.LightYellow;

                ActivarBotones();

                primero = true;
            }
            else
            {
                MessageBox.Show("No puede ingresar la cadena vacia.", "Información", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PintarCinta(string cinta)
        {
            var cintaAux = cinta.ToCharArray();

            for(int i = inicio; i < fin; i++)
            {
                dgvCinta[i, 0].Value = cintaAux[i].ToString();
            }
      
        }

        private void PintarEstado(string estado)
        {
            pBEstado.Image = Properties.Resources.circulo_amarillo;
            Graphics g = Graphics.FromImage(pBEstado.Image);
            g.DrawString("q"+estado, new Font("Arial", 22), Brushes.Black, new Point(10, 12));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int velocidad = trackBar1.Value;
            switch (velocidad)
            {
                case 0: timerEjecucion.Interval = 2500; break;
                case 1: timerEjecucion.Interval = 2000; break;
                case 2: timerEjecucion.Interval = 1500; break;
                case 3: timerEjecucion.Interval = 1000; break;
                case 4: timerEjecucion.Interval = 500; break;
            }

            timerEjecucion.Start();

            btnRun.Enabled = false;
            btnPausa.Enabled = true;
            btnPaso.Enabled = false;
        }

        private void timerEjecucion_Tick(object sender, EventArgs e)
        {
            if (primero)
            {
                cinta = maquinas.PrimerMovimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.p.Cabezal.Posicion;
                MoverCabezal(maquinas.p.Cabezal.Direccion);
                PintarEstado(maquinas.p.Cabezal.Estado.ToString());

                primero = false;
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }
            else
            {
                cinta = maquinas.Movimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.p.Cabezal.Posicion;
                MoverCabezal(maquinas.p.Cabezal.Direccion);
                PintarEstado(maquinas.p.Cabezal.Estado.ToString()); 
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }

            if (maquinas.p.Finalizado == true)
            {
                timerEjecucion.Stop();
                btnReiniciar.Enabled = true;
                //PictureBox de aceptación
                pBAceptacion.BackColor = Color.LightGreen;
                lblAceptacion.Visible = true;
                lblAceptacion.Text = "Estado: Aceptado";
                MessageBox.Show("La cadena de entrada ha sido aceptada.!", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (maquinas.p.Error == true)
            {
                timerEjecucion.Stop();
                btnReiniciar.Enabled = true;
                lblAceptacion.Visible = true;
                lblAceptacion.Text = "Estado: No Aceptado";
                //PictureBox de aceptación
                pBAceptacion.BackColor = Color.LightPink;
                MessageBox.Show("La cadena no fue aceptada.!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaso_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            btnIngresar.Enabled = false;
            txtCadena.Enabled = false;

            if (primero)
            {
                cinta = maquinas.PrimerMovimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.p.Cabezal.Posicion;
                MoverCabezal(maquinas.p.Cabezal.Direccion);
                PintarEstado(maquinas.p.Cabezal.Estado.ToString());

                primero = false;
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }
            else
            {
                cinta = maquinas.Movimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.p.Cabezal.Posicion;
                MoverCabezal(maquinas.p.Cabezal.Direccion);
                PintarEstado(maquinas.p.Cabezal.Estado.ToString());

                pasos++;
                lblNPasos.Text = pasos.ToString();
            }

            if (maquinas.p.Finalizado == true)
            {
                btnPaso.Enabled = false;
                btnReiniciar.Enabled = true;
                lblAceptacion.Visible = true;
                lblAceptacion.Text = "Estado: Aceptado";
                //PictureBox de aceptación
                pBAceptacion.BackColor = Color.LightGreen;
                MessageBox.Show("La cadena de entrada ha sido aceptada.!", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (maquinas.p.Error == true)
            {
                btnPaso.Enabled = false;
                btnReiniciar.Enabled = true;
                lblAceptacion.Visible = true;
                lblAceptacion.Text = "Estado: No Aceptado";
                pBAceptacion.BackColor = Color.LightPink;
                MessageBox.Show("La cadena no fue aceptada.!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
