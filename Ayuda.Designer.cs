namespace Tetris
{
    partial class Ayuda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.lRevision = new System.Windows.Forms.Label();
            this.llLink = new System.Windows.Forms.LinkLabel();
            this.gbControles = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(82, 12);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(122, 29);
            this.lTitulo.TabIndex = 1;
            this.lTitulo.Text = "PS Tetris";
            // 
            // lRevision
            // 
            this.lRevision.AutoSize = true;
            this.lRevision.Location = new System.Drawing.Point(84, 41);
            this.lRevision.Name = "lRevision";
            this.lRevision.Size = new System.Drawing.Size(48, 13);
            this.lRevision.TabIndex = 2;
            this.lRevision.Text = "Revision";
            // 
            // llLink
            // 
            this.llLink.AutoSize = true;
            this.llLink.Location = new System.Drawing.Point(84, 63);
            this.llLink.Name = "llLink";
            this.llLink.Size = new System.Drawing.Size(80, 13);
            this.llLink.TabIndex = 3;
            this.llLink.TabStop = true;
            this.llLink.Text = "Proyect Source";
            this.llLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLink_LinkClicked);
            // 
            // gbControles
            // 
            this.gbControles.Controls.Add(this.textBox1);
            this.gbControles.Location = new System.Drawing.Point(13, 92);
            this.gbControles.Name = "gbControles";
            this.gbControles.Size = new System.Drawing.Size(191, 144);
            this.gbControles.TabIndex = 4;
            this.gbControles.TabStop = false;
            this.gbControles.Text = "Controles";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 125);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "J - Izquierda\r\nL - Derecha\r\n\r\nK - Bajar más rápido\r\n\r\nA - Girar a la izquierda\r\nS" +
                " - Girar a la derecha\r\n\r\nP - Pausar el juego";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(129, 242);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 273);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.gbControles);
            this.Controls.Add(this.llLink);
            this.Controls.Add(this.lRevision);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ayuda";
            this.Text = "Ayuda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbControles.ResumeLayout(false);
            this.gbControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Label lRevision;
        private System.Windows.Forms.LinkLabel llLink;
        private System.Windows.Forms.GroupBox gbControles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bCerrar;
    }
}