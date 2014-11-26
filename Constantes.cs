using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tetris
{
    public static class Constantes
    {
        public static int REVISION = 4;

        public const int FILAS_PIEZAS = 4;
        public const int COLUMNAS_PIEZAS = 4;
        public const int NUM_PIEZAS = 7;
        public const int NUM_ROTACIONES = 4;
        public const int FILAS_PANTALLA = 21;
        public const int COLUMNAS_PANTALLA = 13;
        public const int ANCHO_CELDA = 20;
        public const int ALTO_CELDA = 20;
        public const int NUM_LINEAS_POR_NIVEL = 20;

        public const String SONIDO_MOVERPIEZA = ".\\dat\\moverPieza.wav";
        public const String SONIDO_GIRARPIEZA = ".\\dat\\girarPieza.wav";

        private static Color[] m_COLORES = new Color[7] { Color.Red, Color.Orange, Color.Magenta, Color.Blue, Color.Green, Color.Olive, Color.Cyan }; // Colores oficiales de Tetris

        private static int[] m_NIVELES = new int[10] { 1000, 800, 640, 512, 410, 328, 262, 210, 168, 134 }; // Puntuacion necesaria por niveles

        public static Color COLORES(int color)
        {
            return m_COLORES[color];
        }

        public static int NIVELES(int nivel)
        {
            return m_NIVELES[nivel];
        }
    }
}