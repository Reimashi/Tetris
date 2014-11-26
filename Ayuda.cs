using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tetris
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            this.lRevision.Text = "Revision " + Constantes.REVISION;

            this.llLink.Links.Add(0, llLink.Text.Length, "http://proyectsource.tk"); 
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo); 
        }
    }
}
