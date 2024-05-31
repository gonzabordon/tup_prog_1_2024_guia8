using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        #region variables y metodos del problema
        static int[] numeros = new int[50];
        static int contador = 0;
        #endregion

        #region variables y metodos de la vista
        static int ImprimirMenuYSolicitarOpcion()
        {
            Console.Clear();

            Console.WriteLine("\t\tMenú principal\n\n");

            Console.WriteLine("1- Ingresar listado");
            Console.WriteLine("2- Ordenar y mostrar listado");
            Console.WriteLine("3- busqueda por valor");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        static void MostrarSolicitudListado()
        {

            Console.Clear();

            Console.WriteLine("Ingrese valor: -1 para salir");

            int nro=Convert.ToInt32(Console.ReadLine());
            while (nro > 0)
            {
                numeros[contador] = nro;
                contador++;

                nro=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Prsione un boton para volver al menú principal");
            Console.ReadKey();

        }
        #endregion

        static void Main(string[] args)
        {
            int op = ImprimirMenuYSolicitarOpcion();
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        {
                            MostrarSolicitudListado();
                        }
                        break;
                    default: { op = 0; } break;
                }
                op = ImprimirMenuYSolicitarOpcion();
            }
        }
    }
}
