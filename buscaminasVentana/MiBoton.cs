using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buscaminasVentana
{
    class MiBoton : Button
    {
        private int fila;
        private int columna;

        public MiBoton(int fil, int col) : base()
        {
            this.fila = fil;
            this.columna = col;
            this.AutoSize = true;
        }

        public int getFila()
        {
            return fila;
        }

        public int getColumna()
        {
            return columna;
        }
    }
}
