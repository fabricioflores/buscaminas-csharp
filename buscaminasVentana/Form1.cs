using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buscaminasConsola.models;

namespace buscaminasVentana
{
    public partial class Form1 : Form
    {
        private Tablero tablero = new Tablero(5, 5);
        private MiBoton[,] botones = new MiBoton[5,5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTable();
        }

        private void InitTable()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    MiBoton boton = new MiBoton(i, j);
                    boton.Click += new System.EventHandler(this.levantar);
                    lyt_container.Controls.Add(boton);
                    botones[i-1, j-1] = boton;

                    Console.WriteLine(tablero);
                }
            }
        }

        private void levantar(object sender, EventArgs e)
        {
            MiBoton boton = (MiBoton)sender;
            tablero.LevantaCasilla(boton.getFila(), boton.getColumna());
            boton.Text = tablero.getCasillas()[boton.getFila(), boton.getColumna()].ToString();
            mostrarTexto();
        }

        private void mostrarTexto() {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    MiBoton boton = botones[i - 1, j - 1];
                    boton.Text = tablero.getCasillas()[i, j].ToString();
                }

            }
        } 
    }
}
