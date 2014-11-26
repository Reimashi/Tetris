using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tetris
{
    public partial class formPrincipal : Form
    {
        private Juego t;

        private bool haciaAbajo;
        private bool haciaDerecha;
        private bool haciaIzquierda;
        private bool rotaDerecha;
        private bool rotaIzquierda;
        private bool enPausa;

        private Sound sonidoGirar;
        private Sound sonidoMover;

        public formPrincipal()
        {
            InitializeComponent();

            t = new Juego();

            this.KeyPreview = true;

            sonidoGirar = new Sound(Tetris.Properties.Resources.girarPieza);
            sonidoMover = new Sound(Tetris.Properties.Resources.moverPieza);
        }

        private void bNuevoJuego_Click(object sender, EventArgs e)
        {
            nuevoJuego();
        }

        private void frmGUI_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string strKeyPress = null;
            strKeyPress = e.KeyCode.ToString();
            if (!t.juegoTerminado)
            {
                switch (strKeyPress.ToUpper())
                {
                    case "J":
                        haciaIzquierda = true;
                        break;
                    case "L":
                        haciaDerecha = true;
                        break;
                    case "S":
                        rotaDerecha = true;
                        break;
                    case "A":
                        rotaIzquierda = true;
                        break;
                    case "K":
                        haciaAbajo = true;
                        break;
                    case "P":
                        pausaJuego();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (strKeyPress.ToUpper())
                {
                    case "ENTER":
                        break;

                    default:
                        break;
                }
            }
        }

        private void frmGUI_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string strKeyPress = null;
            strKeyPress = e.KeyCode.ToString();
            if (!t.juegoTerminado)
            {
                switch (strKeyPress.ToUpper())
                {
                    case "J":
                        haciaIzquierda = false;
                        break;
                    case "L":
                        haciaDerecha = false;
                        break;
                    case "K":
                        haciaAbajo = false;
                        break;
                    case "S":
                        rotaDerecha = false;
                        break;
                    case "A":
                        rotaIzquierda = false;
                        break;
                    default:
                        //MessageBox.Show(strKeyPress.ToUpper());
                        break;
                }
            }
        }

        public void pintaPantalla(int[,] matrizPantalla)
        {
            Bitmap B = new Bitmap(pbTablero.Width, pbTablero.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics G = Graphics.FromImage(B);
            G.Clear(Color.Black);
            for (int x = 0; x < Constantes.COLUMNAS_PANTALLA; x++)
            {
                for (int y = 0; y < Constantes.FILAS_PANTALLA; y++)
                {
                    int elemento = matrizPantalla[y, x];
                    if (elemento != 0)
                    {
                        dibujaCuadro(G, y, x, Constantes.COLORES(elemento - 1));
                    }
                }
            }
            pbTablero.Image = B;
        }

        public void pintaPiezaSiguiente(Pieza p)
        {
            Bitmap B = new Bitmap(pbPieza.Width, pbPieza.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics G = Graphics.FromImage(B);
            G.Clear(Color.Black);
            for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
            {
                for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
                {
                    int elemento = t.piezaSiguiente[y, x];
                    if (elemento != 0)
                    {
                        dibujaCuadro(G, y, x, Constantes.COLORES(t.piezaSiguiente.color - 1));
                    }
                }
            }
            pbPieza.Image = B;
        }

        private void dibujaCuadro(Graphics G, int Y, int X, Color C)
        {
            int x = (X * Constantes.ANCHO_CELDA) + 1;
            int y = (Y * Constantes.ALTO_CELDA) + 1;
            SolidBrush Br = new SolidBrush(C);
            G.FillRectangle(Br, x, y, Constantes.ANCHO_CELDA - 2, Constantes.ALTO_CELDA - 2);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
            {
                tbLinea.Text = t.numLineas.ToString();
                tbPuntuacion.Text = t.puntuacion.ToString();
                if (haciaAbajo)
                    actualizaPantalla();
                else
                {
                    haciaAbajo = true;
                    actualizaPantalla();
                    haciaAbajo = false;
                }
                pintaPiezaSiguiente(t.piezaSiguiente);
                if (t.juegoTerminado)
                {
                    timer1.Stop();
                    MessageBox.Show("Se terminó el juego");
                }
            }
        }

        private void timer2_Tick(object sender, System.EventArgs e)
        {
            if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
            {
                actualizaPantalla();
            }
            else
            {
                timer2.Stop();
                timer1.Stop();
                tbLinea.Text = t.numLineas.ToString();
                tbPuntuacion.Text = t.puntuacion.ToString();
                inicializaTeclas();
                t.nuevoNivel();
                MessageBox.Show("¡¡Enhorabuena!! Has pasado al nivel " + (t.nivel + 1));
                tbNivelo.Text = ((int)t.nivel + 1).ToString();
                timer1.Interval = Constantes.NIVELES(t.nivel);
                timer2.Start();
                timer1.Start();
            }
            if (t.juegoTerminado)
            {
                timer2.Stop();
            }
        }

        private void actualizaPantalla()
        {
            if (haciaAbajo)
            {
                t.muevePiezaAbajo();
            }
            if (haciaDerecha)
            {
                t.muevePiezaDerecha();
                sonidoMover.Play();
            }
            if (haciaIzquierda)
            {
                t.muevePiezaIzquierda();
                sonidoMover.Play();
            }
            if (rotaDerecha)
            {
                t.rotaPiezaDerecha();
                sonidoGirar.Play();
                rotaDerecha = false;
            }
            if (rotaIzquierda)
            {
                t.rotaPiezaIzquierda();
                sonidoGirar.Play();
                rotaIzquierda = false;
            }

            pintaPantalla(t.matrizPantalla);
        }

        private void inicializaTeclas()
        {
            haciaDerecha = false;
            haciaIzquierda = false;
            rotaDerecha = false;
            rotaIzquierda = false;
            haciaAbajo = false;
            enPausa = false;
        }

        private void nuevoJuego()
        {
            inicializaTeclas();
            t.nuevoJuego();
            tbPuntuacion.Text = "0";
            tbNivelo.Text = "1";
            timer1.Interval = Constantes.NIVELES(t.nivel);
            pintaPantalla(t.matrizPantalla);
            timer1.Start();
            timer2.Start();
        }

        private void pausaJuego()
        {
            if (!t.juegoTerminado)
            {
                if (!enPausa)
                {
                    timer1.Stop();
                    timer2.Stop();
                }
                else
                {
                    timer1.Start();
                    timer2.Start();
                }
                enPausa = !enPausa;
            }
        }

        private void bPausa_Click(object sender, EventArgs e)
        {
            pausaJuego();
        }

        private void bAyuda_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.Show();
        }
    }
}
