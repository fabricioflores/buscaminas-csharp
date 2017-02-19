using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscaminasConsola.models
{
    class Casilla
    {
        private int valor;
        private bool levantada;
        private bool bomba;
        private bool marcada;

        public bool Marcada
        {
            get
            {
                return this.marcada;
            }
            set
            {
                this.marcada = value;
            }
        }
        public Casilla()
        {
            levantada = true;
            valor = 0;
            bomba = false;
        }
        public bool EsBomba()
        {
            return bomba;
        }
        public void SumarUno()
        {
            valor = valor + 1;
        }

        public void PonBomba()
        {
            bomba = true;
        }

        public override string ToString()
        {
            string msg = "";
            this.marcada = false;
            if (!levantada)
            {
                msg = "X";
            }
            else
            {
                if (bomba)
                {
                    msg = "B";
                }
                else if (valor == 0)
                {
                    msg = "-";
                }
                else
                {
                    msg = "" + valor;
                }
            }
            return msg;
        }

        internal void Levanta()
        {
            this.levantada = true;
        }

        public bool EsVacia()
        {
            return this.valor == 0 && !EsBomba();
        }

        internal bool EstaLevantada()
        {
            return levantada;
        }
    }
}
