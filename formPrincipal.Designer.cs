namespace Tetris
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.pbTablero = new System.Windows.Forms.PictureBox();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.bPausa = new System.Windows.Forms.Button();
            this.bNuevoJuego = new System.Windows.Forms.Button();
            this.pbPieza = new System.Windows.Forms.PictureBox();
            this.gbpuntuacion = new System.Windows.Forms.GroupBox();
            this.tbPuntuacion = new System.Windows.Forms.TextBox();
            this.lPuntuacion = new System.Windows.Forms.Label();
            this.tbNivelo = new System.Windows.Forms.TextBox();
            this.lNivel = new System.Windows.Forms.Label();
            this.lLineas = new System.Windows.Forms.Label();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.gbPPieaza = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).BeginInit();
            this.gbControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPieza)).BeginInit();
            this.gbpuntuacion.SuspendLayout();
            this.gbPPieaza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTablero
            // 
            this.pbTablero.BackColor = System.Drawing.Color.Black;
            this.pbTablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTablero.Location = new System.Drawing.Point(12, 12);
            this.pbTablero.Name = "pbTablero";
            this.pbTablero.Size = new System.Drawing.Size(260, 420);
            this.pbTablero.TabIndex = 0;
            this.pbTablero.TabStop = false;
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.bPausa);
            this.gbControles.Controls.Add(this.bNuevoJuego);
            this.gbControles.Location = new System.Drawing.Point(278, 12);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(91, 94);
            this.gbControles.TabIndex = 1;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // bPausa
            // 
            this.bPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPausa.Location = new System.Drawing.Point(6, 67);
            this.bPausa.Name = "bPausa";
            this.bPausa.Size = new System.Drawing.Size(79, 21);
            this.bPausa.TabIndex = 1;
            this.bPausa.Text = "||";
            this.bPausa.UseVisualStyleBackColor = true;
            this.bPausa.Click += new System.EventHandler(this.bPausa_Click);
            // 
            // bNuevoJuego
            // 
            this.bNuevoJuego.Location = new System.Drawing.Point(5, 19);
            this.bNuevoJuego.Name = "bNuevoJuego";
            this.bNuevoJuego.Size = new System.Drawing.Size(80, 40);
            this.bNuevoJuego.TabIndex = 0;
            this.bNuevoJuego.Text = "Nuevo Juego";
            this.bNuevoJuego.UseVisualStyleBackColor = true;
            this.bNuevoJuego.Click += new System.EventHandler(this.bNuevoJuego_Click);
            // 
            // pbPieza
            // 
            this.pbPieza.BackColor = System.Drawing.Color.Black;
            this.pbPieza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPieza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPieza.Location = new System.Drawing.Point(3, 16);
            this.pbPieza.Name = "pbPieza";
            this.pbPieza.Size = new System.Drawing.Size(85, 85);
            this.pbPieza.TabIndex = 2;
            this.pbPieza.TabStop = false;
            // 
            // gbpuntuacion
            // 
            this.gbpuntuacion.Controls.Add(this.tbPuntuacion);
            this.gbpuntuacion.Controls.Add(this.lPuntuacion);
            this.gbpuntuacion.Controls.Add(this.tbNivelo);
            this.gbpuntuacion.Controls.Add(this.lNivel);
            this.gbpuntuacion.Controls.Add(this.lLineas);
            this.gbpuntuacion.Controls.Add(this.tbLinea);
            this.gbpuntuacion.Location = new System.Drawing.Point(278, 219);
            this.gbpuntuacion.Name = "gbpuntuacion";
            this.gbpuntuacion.Size = new System.Drawing.Size(91, 153);
            this.gbpuntuacion.TabIndex = 3;
            this.gbpuntuacion.TabStop = false;
            // 
            // tbPuntuacion
            // 
            this.tbPuntuacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbPuntuacion.Location = new System.Drawing.Point(9, 127);
            this.tbPuntuacion.Name = "tbPuntuacion";
            this.tbPuntuacion.ReadOnly = true;
            this.tbPuntuacion.Size = new System.Drawing.Size(71, 20);
            this.tbPuntuacion.TabIndex = 5;
            this.tbPuntuacion.TabStop = false;
            // 
            // lPuntuacion
            // 
            this.lPuntuacion.AutoSize = true;
            this.lPuntuacion.Location = new System.Drawing.Point(6, 111);
            this.lPuntuacion.Name = "lPuntuacion";
            this.lPuntuacion.Size = new System.Drawing.Size(61, 13);
            this.lPuntuacion.TabIndex = 4;
            this.lPuntuacion.Text = "Puntuación";
            // 
            // tbNivelo
            // 
            this.tbNivelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbNivelo.Location = new System.Drawing.Point(9, 76);
            this.tbNivelo.Name = "tbNivelo";
            this.tbNivelo.ReadOnly = true;
            this.tbNivelo.Size = new System.Drawing.Size(71, 20);
            this.tbNivelo.TabIndex = 3;
            this.tbNivelo.TabStop = false;
            // 
            // lNivel
            // 
            this.lNivel.AutoSize = true;
            this.lNivel.Location = new System.Drawing.Point(6, 60);
            this.lNivel.Name = "lNivel";
            this.lNivel.Size = new System.Drawing.Size(31, 13);
            this.lNivel.TabIndex = 2;
            this.lNivel.Text = "Nivel";
            // 
            // lLineas
            // 
            this.lLineas.AutoSize = true;
            this.lLineas.Location = new System.Drawing.Point(6, 16);
            this.lLineas.Name = "lLineas";
            this.lLineas.Size = new System.Drawing.Size(38, 13);
            this.lLineas.TabIndex = 1;
            this.lLineas.Text = "Lineas";
            // 
            // tbLinea
            // 
            this.tbLinea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLinea.Location = new System.Drawing.Point(9, 32);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.ReadOnly = true;
            this.tbLinea.Size = new System.Drawing.Size(71, 20);
            this.tbLinea.TabIndex = 0;
            this.tbLinea.TabStop = false;
            // 
            // gbPPieaza
            // 
            this.gbPPieaza.Controls.Add(this.pbPieza);
            this.gbPPieaza.Location = new System.Drawing.Point(278, 112);
            this.gbPPieaza.Name = "gbPPieaza";
            this.gbPPieaza.Size = new System.Drawing.Size(91, 104);
            this.gbPPieaza.TabIndex = 4;
            this.gbPPieaza.TabStop = false;
            this.gbPPieaza.Text = "Prox. Pieza";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bAyuda
            // 
            this.bAyuda.Location = new System.Drawing.Point(353, 412);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(16, 20);
            this.bAyuda.TabIndex = 5;
            this.bAyuda.Text = "?";
            this.bAyuda.UseVisualStyleBackColor = true;
            this.bAyuda.Click += new System.EventHandler(this.bAyuda_Click);
            // 
            // fTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 444);
            this.Controls.Add(this.bAyuda);
            this.Controls.Add(this.gbPPieaza);
            this.Controls.Add(this.gbpuntuacion);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.pbTablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fTetris";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbTablero)).EndInit();
            this.gbControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPieza)).EndInit();
            this.gbpuntuacion.ResumeLayout(false);
            this.gbpuntuacion.PerformLayout();
            this.gbPPieaza.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTablero;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.Button bPausa;
        private System.Windows.Forms.Button bNuevoJuego;
        private System.Windows.Forms.PictureBox pbPieza;
        private System.Windows.Forms.GroupBox gbpuntuacion;
        private System.Windows.Forms.TextBox tbPuntuacion;
        private System.Windows.Forms.Label lPuntuacion;
        private System.Windows.Forms.TextBox tbNivelo;
        private System.Windows.Forms.Label lNivel;
        private System.Windows.Forms.Label lLineas;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.GroupBox gbPPieaza;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button bAyuda;
    }
}