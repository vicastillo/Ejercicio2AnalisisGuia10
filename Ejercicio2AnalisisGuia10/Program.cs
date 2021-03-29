using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Matriz
    {
        private int[,] mat;

        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.IngresoDeDatos();
            ma.Mayor();
            ma.Menor();
        }
        public void IngresoDeDatos()
        {
            Console.Write("Ingrese la cantidad de filas que tendrá la matriz: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.Write("Ingrese la cantidad de columnas que tendrá la matriz: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Digite el valor: ");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Mayor()
        {
            int mayor = mat[0, 0];
            int filamay = 0;
            int columnamay = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mayor)
                    {
                        mayor = mat[f, c];
                        filamay = f;
                        columnamay = c;
                    }
                }
            }
            Console.WriteLine("El mayor elemento es:" + mayor);
        }

        public void Menor()
        {
            int menor = mat[0, 0];
            int filamen = 0;
            int columnamen = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] < menor)
                    {
                        menor = mat[f, c];
                        filamen = f;
                        columnamen = c;
                    }
                }
            }
            Console.WriteLine("El menor elemento es:" + menor);
            Console.ReadLine();
        }


    }
}