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
        int maquina;
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
            maquina = 0;
            primero = false;

            txtInformacion.Text = "Máquina de Turing que reconoce una " +
                                   "cadena de a, b o c's y verifica si " +
                                   "la cadena es un palíndromo.";
        }

        private void IniciarPicturesBox()
        {
            //PictureBox de estado
            pBEstado.Image = Properties.Resources.circulo_amarillo;
            Graphics g = Graphics.FromImage(pBEstado.Image);
            g.DrawString("q0", new Font("Arial", 22), Brushes.Black, new Point(10, 12));
            
        }

        private void DeshabilitarBotones()
        {
            btnRun.Enabled = false;
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
                        dgvCinta[posicionCabezal + 1, 0].Style.BackColor = Color.White;
                        dgvCinta[posicionCabezal, 0].Style.BackColor = Color.Cyan;
                    break;
                case 1:
                        dgvCinta[posicionCabezal - 1, 0].Style.BackColor = Color.White;
                        dgvCinta[posicionCabezal, 0].Style.BackColor = Color.Cyan;
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
                maquinas.Error = false;
                maquinas.Finalizado = false;

                if (longitud <= 19)
                {
                    cinta = "ββ" + cadena;
                    for (int i = cinta.Length; i <= 21; i++)
                    {
                            cinta += "β";
                    }          
                }
                else {
                    cinta = "ββ" + cadena;

                    for (int i = cinta.Length; i <= longitud + 3; i++)
                    {
                        cinta += "β";
                    }

                    int columns = dgvCinta.ColumnCount;

                    DataGridViewColumn columna;

                    for(int i = columns + 1; i <= cinta.Length; i++)
                    {
                        columna = new DataGridViewColumn();
                        columna.HeaderText = "Columna" + i;
                        columna.CellTemplate = new DataGridViewTextBoxCell();
                        columna.Width = 40;
                        columna.Resizable = DataGridViewTriState.False;
                        dgvCinta.Columns.Add(columna);
                    }

                    dgvCinta.Size = new Size(843, 60);
                }

                //Ingresar cadena a la cinta
                PintarCinta(cinta);

                //Reacomodamiento del cabezal
                posicionCabezal = 2;
                dgvCinta[posicionCabezal, 0].Style.BackColor = Color.Cyan;

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

            for(int i = 0; i < cinta.Length-1; i++)
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
                case 0: timerEjecucion.Interval = 1400; break;
                case 1: timerEjecucion.Interval = 1200; break;
                case 2: timerEjecucion.Interval = 900; break;
                case 3: timerEjecucion.Interval = 400; break;
                case 4: timerEjecucion.Interval = 100; break;
            }

            timerEjecucion.Start();

            btnRun.Enabled = false;
            btnPaso.Enabled = false;
            btnIngresar.Enabled = false;
            txtCadena.Enabled = false;
        }

        private void timerEjecucion_Tick(object sender, EventArgs e)
        {
            if (primero)
            {
                cinta = maquinas.PrimerMovimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.main.Posicion;
                MoverCabezal(maquinas.main.Direccion);
                PintarEstado(maquinas.main.Estado.ToString());

                primero = false;
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }
            else
            {
                cinta = maquinas.Movimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.main.Posicion;
                MoverCabezal(maquinas.main.Direccion);
                PintarEstado(maquinas.main.Estado.ToString()); 
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }

            if (maquinas.Finalizado == true)
            {
                timerEjecucion.Stop();
                btnReiniciar.Enabled = true;
                //PictureBox de aceptación
                pBAceptacion.BackColor = Color.LightGreen;
                MessageBox.Show("La cadena de entrada ha sido aceptada.!", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (maquinas.Error == true)
            {
                timerEjecucion.Stop();
                btnReiniciar.Enabled = true;
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
                posicionCabezal = maquinas.main.Posicion;
                MoverCabezal(maquinas.main.Direccion);
                PintarEstado(maquinas.main.Estado.ToString());

                primero = false;
                pasos++;
                lblNPasos.Text = pasos.ToString();
            }
            else
            {
                cinta = maquinas.Movimiento(cinta, maquina, posicionCabezal);
                PintarCinta(cinta);
                posicionCabezal = maquinas.main.Posicion;
                MoverCabezal(maquinas.main.Direccion);
                PintarEstado(maquinas.main.Estado.ToString());

                pasos++;
                lblNPasos.Text = pasos.ToString();
            }

            if (maquinas.Finalizado == true)
            {
                btnPaso.Enabled = false;
                btnReiniciar.Enabled = true;
                //PictureBox de aceptación
                pBAceptacion.BackColor = Color.LightGreen;
                MessageBox.Show("La cadena de entrada ha sido aceptada.!", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (maquinas.Error == true)
            {
                btnPaso.Enabled = false;
                btnReiniciar.Enabled = true;
                pBAceptacion.BackColor = Color.LightPink;
                MessageBox.Show("La cadena no fue aceptada.!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvCinta[posicionCabezal, 0].Style.BackColor = Color.Empty;
            //Quitar las columnas que se agregaron
            int count = dgvCinta.Columns.Count;

            for (int i = count-1; i >= 21; i--)
            {
                dgvCinta.Columns.RemoveAt(i);
            }

            DeshabilitarBotones();
            btnIngresar.Enabled = true;
            txtCadena.Text = string.Empty;
            txtCadena.Enabled = true;
            IniciarCinta();
            pBAceptacion.BackColor = Color.Empty;    
            pasos = 0;
            lblNPasos.Text = pasos.ToString();
            PintarEstado("0");
            maquinas = new MaquinaTuring();
            cinta = string.Empty;

            //Reescribir el datagrid
            dgvCinta.Size = new Size(843, 43);
            
        }

        private void rbtnPalindromos_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = "Máquina de Turing que reconoce una " +
                                   "\ncadena de a, b o c's y verifica si" +
                                   "\nla cadena es un palíndromo.";
        }

        private void rbtnCopiar_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = "Máquina de Turing que reconoce patrones" +
                                  " de a, b o c's y lo copia de manera idéntica.";                  
        }

        private void rbtnMult_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = "Máquina de Turing que reconoce una cadena " +
                                  "en código unario y realiza la respectiva " +
                                  "multiplicación. El simbolo es el ' 1 ' y como " +
                                  "signo de multiplicación se usa el ' * '";
        }

        private void rbtnSuma_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = "Máquina de Turing que reconoce una cadena " +
                                   "en código unario y realiza la suma respectiva. " +
                                   "El simbolo es el ' 1 ' y como signo de suma se usa el ' + '";
        }

        private void rbtnResta_Click(object sender, EventArgs e)
        {
            txtInformacion.Text = "Máquina de Turing que reconoce una cadena " +
                                   "en código unario y realiza la resta respectiva. " +
                                   "El simbolo es el ' 1 ' y como signo de resta se usa el ' - '";
        }
    }
}
