using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buscaminasConsola.models;

namespace buscaminasConsola
{
    class buscaminasConsola
    {
        static void Main(string[] args)
        {
            new buscaminasConsola().Comenzar();
        }

        private void Comenzar()
        {
            int n = 5;
            int m = 8;
            Tablero tablero = new Tablero(n, m);
            Console.WriteLine(tablero);
            Console.WriteLine("Fila 1 -->");
            int fila = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Columna 1 -->");
            int columna = Int32.Parse(Console.ReadLine());
            tablero.LevantaCasilla(fila, columna);
            Console.WriteLine(tablero);
            Console.Read();

        }

    }
}
