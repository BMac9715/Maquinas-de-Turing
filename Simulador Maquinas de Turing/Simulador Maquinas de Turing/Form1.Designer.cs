namespace Simulador_Maquinas_de_Turing
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gBControl = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblFast = new System.Windows.Forms.Label();
            this.lblSlow = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnPaso = new System.Windows.Forms.Button();
            this.gBInformacion = new System.Windows.Forms.GroupBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.rbtnCopiar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnMult = new System.Windows.Forms.RadioButton();
            this.rbtnPalindromos = new System.Windows.Forms.RadioButton();
            this.gBSalida = new System.Windows.Forms.GroupBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.pBEstado = new System.Windows.Forms.PictureBox();
            this.lblNPasos = new System.Windows.Forms.Label();
            this.lblPasos = new System.Windows.Forms.Label();
            this.gBCinta = new System.Windows.Forms.GroupBox();
            this.dgvCinta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBAceptacion = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.timerEjecucion = new System.Windows.Forms.Timer(this.components);
            this.gBControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.gBInformacion.SuspendLayout();
            this.gBSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEstado)).BeginInit();
            this.gBCinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAceptacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gBControl
            // 
            this.gBControl.Controls.Add(this.btnIngresar);
            this.gBControl.Controls.Add(this.lblFast);
            this.gBControl.Controls.Add(this.lblSlow);
            this.gBControl.Controls.Add(this.btnReiniciar);
            this.gBControl.Controls.Add(this.trackBar1);
            this.gBControl.Controls.Add(this.label1);
            this.gBControl.Controls.Add(this.btnRun);
            this.gBControl.Controls.Add(this.lblEntrada);
            this.gBControl.Controls.Add(this.txtCadena);
            this.gBControl.Controls.Add(this.btnPaso);
            this.gBControl.Location = new System.Drawing.Point(537, 324);
            this.gBControl.Name = "gBControl";
            this.gBControl.Size = new System.Drawing.Size(375, 194);
            this.gBControl.TabIndex = 16;
            this.gBControl.TabStop = false;
            this.gBControl.Text = "Entrada - Control";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(281, 19);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 36);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Cargar Cadena";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblFast
            // 
            this.lblFast.AutoSize = true;
            this.lblFast.Location = new System.Drawing.Point(321, 100);
            this.lblFast.Name = "lblFast";
            this.lblFast.Size = new System.Drawing.Size(41, 13);
            this.lblFast.TabIndex = 10;
            this.lblFast.Text = "Rápido";
            // 
            // lblSlow
            // 
            this.lblSlow.AutoSize = true;
            this.lblSlow.Location = new System.Drawing.Point(22, 100);
            this.lblSlow.Name = "lblSlow";
            this.lblSlow.Size = new System.Drawing.Size(34, 13);
            this.lblSlow.TabIndex = 9;
            this.lblSlow.Text = "Lento";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(271, 146);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(71, 29);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reset";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(63, 95);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Velocidad de Ejecución";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(36, 146);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(71, 29);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 27);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 6;
            this.lblEntrada.Text = "Cadena";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(77, 27);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(177, 20);
            this.txtCadena.TabIndex = 5;
            // 
            // btnPaso
            // 
            this.btnPaso.Location = new System.Drawing.Point(155, 146);
            this.btnPaso.Name = "btnPaso";
            this.btnPaso.Size = new System.Drawing.Size(75, 29);
            this.btnPaso.TabIndex = 4;
            this.btnPaso.Text = "Step";
            this.btnPaso.UseVisualStyleBackColor = true;
            this.btnPaso.Click += new System.EventHandler(this.btnPaso_Click);
            // 
            // gBInformacion
            // 
            this.gBInformacion.Controls.Add(this.txtInformacion);
            this.gBInformacion.Controls.Add(this.lblMaquinas);
            this.gBInformacion.Controls.Add(this.rbtnCopiar);
            this.gBInformacion.Controls.Add(this.lblInformacion);
            this.gBInformacion.Controls.Add(this.rbtnSuma);
            this.gBInformacion.Controls.Add(this.rbtnResta);
            this.gBInformacion.Controls.Add(this.rbtnMult);
            this.gBInformacion.Controls.Add(this.rbtnPalindromos);
            this.gBInformacion.Location = new System.Drawing.Point(21, 178);
            this.gBInformacion.Name = "gBInformacion";
            this.gBInformacion.Size = new System.Drawing.Size(507, 190);
            this.gBInformacion.TabIndex = 17;
            this.gBInformacion.TabStop = false;
            this.gBInformacion.Text = "Maquinas y Caracteristicas";
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(266, 49);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ReadOnly = true;
            this.txtInformacion.Size = new System.Drawing.Size(215, 109);
            this.txtInformacion.TabIndex = 17;
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Location = new System.Drawing.Point(20, 27);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Size = new System.Drawing.Size(158, 13);
            this.lblMaquinas.TabIndex = 8;
            this.lblMaquinas.Text = "Maquinas de Turing Disponibles";
            // 
            // rbtnCopiar
            // 
            this.rbtnCopiar.AutoSize = true;
            this.rbtnCopiar.Location = new System.Drawing.Point(38, 72);
            this.rbtnCopiar.Name = "rbtnCopiar";
            this.rbtnCopiar.Size = new System.Drawing.Size(111, 17);
            this.rbtnCopiar.TabIndex = 12;
            this.rbtnCopiar.TabStop = true;
            this.rbtnCopiar.Text = "Copia de patrones";
            this.rbtnCopiar.UseVisualStyleBackColor = true;
            this.rbtnCopiar.Click += new System.EventHandler(this.rbtnCopiar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(263, 27);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(167, 13);
            this.lblInformacion.TabIndex = 15;
            this.lblInformacion.Text = "Informacion acerca de la máquina";
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(38, 118);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(134, 17);
            this.rbtnSuma.TabIndex = 9;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "Suma en código unario";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            this.rbtnSuma.Click += new System.EventHandler(this.rbtnSuma_Click);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(38, 141);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(135, 17);
            this.rbtnResta.TabIndex = 10;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta en código unario";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.Click += new System.EventHandler(this.rbtnResta_Click);
            // 
            // rbtnMult
            // 
            this.rbtnMult.AutoSize = true;
            this.rbtnMult.Location = new System.Drawing.Point(38, 95);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(171, 17);
            this.rbtnMult.TabIndex = 13;
            this.rbtnMult.TabStop = true;
            this.rbtnMult.Text = "Multiplicación en código unario";
            this.rbtnMult.UseVisualStyleBackColor = true;
            this.rbtnMult.Click += new System.EventHandler(this.rbtnMult_Click);
            // 
            // rbtnPalindromos
            // 
            this.rbtnPalindromos.AutoSize = true;
            this.rbtnPalindromos.Location = new System.Drawing.Point(38, 49);
            this.rbtnPalindromos.Name = "rbtnPalindromos";
            this.rbtnPalindromos.Size = new System.Drawing.Size(208, 17);
            this.rbtnPalindromos.TabIndex = 11;
            this.rbtnPalindromos.TabStop = true;
            this.rbtnPalindromos.Text = "Reconocedor de cadenas palindromas";
            this.rbtnPalindromos.UseVisualStyleBackColor = true;
            this.rbtnPalindromos.Click += new System.EventHandler(this.rbtnPalindromos_Click);
            // 
            // gBSalida
            // 
            this.gBSalida.Controls.Add(this.lblEstados);
            this.gBSalida.Controls.Add(this.pBEstado);
            this.gBSalida.Controls.Add(this.lblNPasos);
            this.gBSalida.Controls.Add(this.lblPasos);
            this.gBSalida.Location = new System.Drawing.Point(534, 185);
            this.gBSalida.Name = "gBSalida";
            this.gBSalida.Size = new System.Drawing.Size(365, 128);
            this.gBSalida.TabIndex = 18;
            this.gBSalida.TabStop = false;
            this.gBSalida.Text = "Salida";
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(21, 30);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(122, 20);
            this.lblEstados.TabIndex = 14;
            this.lblEstados.Text = "Estado Actual";
            // 
            // pBEstado
            // 
            this.pBEstado.Location = new System.Drawing.Point(168, 15);
            this.pBEstado.Name = "pBEstado";
            this.pBEstado.Size = new System.Drawing.Size(50, 50);
            this.pBEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBEstado.TabIndex = 11;
            this.pBEstado.TabStop = false;
            // 
            // lblNPasos
            // 
            this.lblNPasos.AutoSize = true;
            this.lblNPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPasos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNPasos.Location = new System.Drawing.Point(197, 83);
            this.lblNPasos.Name = "lblNPasos";
            this.lblNPasos.Size = new System.Drawing.Size(24, 26);
            this.lblNPasos.TabIndex = 16;
            this.lblNPasos.Text = "0";
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasos.Location = new System.Drawing.Point(21, 87);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(160, 20);
            this.lblPasos.TabIndex = 14;
            this.lblPasos.Text = "Numero de Pasos: ";
            // 
            // gBCinta
            // 
            this.gBCinta.Controls.Add(this.dgvCinta);
            this.gBCinta.Controls.Add(this.pBAceptacion);
            this.gBCinta.Location = new System.Drawing.Point(18, 45);
            this.gBCinta.Name = "gBCinta";
            this.gBCinta.Size = new System.Drawing.Size(881, 127);
            this.gBCinta.TabIndex = 4;
            this.gBCinta.TabStop = false;
            this.gBCinta.Text = "Cinta";
            // 
            // dgvCinta
            // 
            this.dgvCinta.AllowUserToAddRows = false;
            this.dgvCinta.AllowUserToDeleteRows = false;
            this.dgvCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCinta.ColumnHeadersVisible = false;
            this.dgvCinta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinta.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCinta.EnableHeadersVisualStyles = false;
            this.dgvCinta.Location = new System.Drawing.Point(18, 44);
            this.dgvCinta.MultiSelect = false;
            this.dgvCinta.Name = "dgvCinta";
            this.dgvCinta.ReadOnly = true;
            this.dgvCinta.RowHeadersVisible = false;
            this.dgvCinta.RowHeadersWidth = 75;
            this.dgvCinta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCinta.RowTemplate.Height = 40;
            this.dgvCinta.RowTemplate.ReadOnly = true;
            this.dgvCinta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCinta.Size = new System.Drawing.Size(843, 43);
            this.dgvCinta.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Width = 40;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column11.Width = 40;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Width = 40;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column13.Width = 40;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column14.Width = 40;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column15.Width = 40;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column16.Width = 40;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Column17";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column17.Width = 40;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Column18";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column18.Width = 40;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Column19";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column19.Width = 40;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Column20";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column20.Width = 40;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Column21";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column21.Width = 40;
            // 
            // pBAceptacion
            // 
            this.pBAceptacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBAceptacion.Location = new System.Drawing.Point(3, 16);
            this.pBAceptacion.Name = "pBAceptacion";
            this.pBAceptacion.Size = new System.Drawing.Size(875, 108);
            this.pBAceptacion.TabIndex = 12;
            this.pBAceptacion.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(185, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(483, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Simulador de Maquinas de Turing";
            // 
            // timerEjecucion
            // 
            this.timerEjecucion.Tick += new System.EventHandler(this.timerEjecucion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 529);
            this.Controls.Add(this.gBCinta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gBSalida);
            this.Controls.Add(this.gBInformacion);
            this.Controls.Add(this.gBControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Maquinas de Turing";
            this.gBControl.ResumeLayout(false);
            this.gBControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.gBInformacion.ResumeLayout(false);
            this.gBInformacion.PerformLayout();
            this.gBSalida.ResumeLayout(false);
            this.gBSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBEstado)).EndInit();
            this.gBCinta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBAceptacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBControl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnPaso;
        private System.Windows.Forms.GroupBox gBInformacion;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.RadioButton rbtnCopiar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnMult;
        private System.Windows.Forms.RadioButton rbtnPalindromos;
        private System.Windows.Forms.GroupBox gBSalida;
        private System.Windows.Forms.GroupBox gBCinta;
        private System.Windows.Forms.PictureBox pBEstado;
        private System.Windows.Forms.PictureBox pBAceptacion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblFast;
        private System.Windows.Forms.Label lblSlow;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvCinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.Timer timerEjecucion;
        private System.Windows.Forms.Label lblNPasos;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Label lblEstados;
    }
}

