using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminasConsola.models
{
    class Tablero
    {
        private int fils;
        private int cols;
        private Casilla[,] casillas;

        public Tablero(int n, int m)
        {
            this.fils = n + 2;
            this.cols = m + 2;
            this.casillas = new Casilla[this.fils, this.cols];
            for (int f = 0; f < this.fils; f++)
            {
                for (int c = 0; c < this.cols; c++)
                {
                    this.casillas[f, c] = new Casilla();
                }
            }
            PonUnosEnElBorde();
            PonBombas();
        }

        private void PonUnosEnElBorde()
        {
            for (int c = 0; c < cols; c++)
            {
                casillas[0, c].SumarUno();
                casillas[fils - 1, c].SumarUno();
            }

            for (int f = 0; f < fils; f++)
            {
                casillas[f, 0].SumarUno();
                casillas[f, cols - 1].SumarUno();
            }
        }

        private void PonBombas()
        {
            Random rnd = new Random();
            for (int f = 1; f < this.fils - 1; f++)
            {
                for (int c = 1; c < this.cols - 1; c++)
                {
                    if (rnd.Next(100) < 20)
                    {
                        this.casillas[f, c].PonBomba();
                        SumaUnosALrededor(f, c);
                    }
                }

            }
        }

        public void LevantaCasilla(int fila, int columna)
        {
            this.casillas[fila, columna].Levanta();
            if (this.casillas[fila, columna].EsVacia())
            {
                for (int f = fila - 1; f <= (fila + 1); f++)
                {
                    for (int c = columna - 1; c <= (columna + 1); c++)
                    {
                        if (!this.casillas[f, c].EstaLevantada())
                        {
                            LevantaCasilla(f, c);
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            string msg = "";
            for (int f = 1; f < this.fils - 1; f++)
            {
                for (int c = 1; c < this.cols - 1; c++)
                {
                    msg += " " + casillas[f, c];
                }
                msg += "\n";
            }
            return msg;
        }

        private void SumaUnosALrededor(int fila, int columna)
        {
            for (int i = (fila - 1); i <= (fila + 1); i++)
            {
                for (int j = (columna - 1); j <= (columna + 1); j++)
                {
                    this.casillas[i, j].SumarUno();
                }
            }
        }

        public Casilla[,] getCasillas() {
            return this.casillas;
        }
    }
}
