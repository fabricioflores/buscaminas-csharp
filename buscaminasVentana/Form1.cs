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
        private Tablero tablero;
        private MiBoton[,] botones;
        private int selection;
        private int cantidadAplastados;
        private int puntuacion;
        private string user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitTable()
        {
            puntuacion = 0;
            tablero = new Tablero(selection, selection);
            botones = new MiBoton[selection, selection];
            lyt_container.RowCount = selection;
            lyt_container.ColumnCount = selection;

            lyt_container.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            lyt_container.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (int i = 1; i <= selection; i++)
            {
                for (int j = 1; j <= selection; j++)
                {
                    MiBoton boton = new MiBoton(i, j);
                    boton.Click += new System.EventHandler(this.levantar);
                    lyt_container.Controls.Add(boton);
                    botones[i-1, j-1] = boton;
                }
            }
        }

        private void levantar(object sender, EventArgs e)
        {
            puntuacion++;
            MiBoton boton = (MiBoton)sender;
            tablero.LevantaCasilla(boton.getFila(), boton.getColumna());
            boton.Text = tablero.getCasillas()[boton.getFila(), boton.getColumna()].ToString();
            Console.WriteLine(tablero.ToString());
            if (boton.Text == "B")
            {
                MessageBox.Show("Perdiste!!!");
                deshabilitarTodo();
            }
            else
            {
                mostrarTexto();
                if (tablero.cantidadBombas == cantidadAplastados)
                {
                    MessageBox.Show("Ganaste, "+ user +"\nMovimientos: " + puntuacion);
                    deshabilitarTodo();
                }
            }
        }

        private void deshabilitarTodo() {
            for (int i = 0; i < selection; i++)
            {
                for (int j = 0; j < selection; j++)
                {
                    botones[i, j].Enabled = false;
                }
            }
        }

        private void mostrarTexto() {
            cantidadAplastados = selection * selection;
            for (int i = 1; i <= selection; i++)
            {
                for (int j = 1; j <= selection; j++)
                {
                    MiBoton boton = botones[i - 1, j - 1];
                    boton.Text = tablero.getCasillas()[i, j].ToString();
                    if (boton.Text != " ")
                    {
                        boton.Enabled = false;
                        cantidadAplastados--;
                    }
                }

            }
        }

        private void rb_easy_CheckedChanged(object sender, EventArgs e)
        {
            selection = 5;
            btn_start.Enabled = true;
        }

        private void rb_hard_CheckedChanged(object sender, EventArgs e)
        {
            selection = 8;
            btn_start.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lyt_container.Controls.Clear();
            user = txt_name.Text.Equals("") ? "usuario desconocido ;-)" : txt_name.Name;
            InitTable();
        }
    }
}
