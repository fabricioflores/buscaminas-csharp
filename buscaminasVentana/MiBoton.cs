using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.Size = new Size(30, 30);
            this.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
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
