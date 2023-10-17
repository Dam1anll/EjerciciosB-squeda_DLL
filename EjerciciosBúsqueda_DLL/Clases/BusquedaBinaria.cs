using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBúsqueda_DLL.Clases
{
    public class BusquedaBinaria
    {
        public void BuscarNumeroMenorMayor()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }; 

            Console.Write("Ingresa un número para buscar en el arreglo: ");
            int numeroBuscar = int.Parse(Console.ReadLine());

            int posicion = Busqueda(numeros, numeroBuscar);

            if (posicion != -1)
            {
                Console.WriteLine("El número " + numeroBuscar + " se encuentra en la posición " + posicion);
            }
            else
            {
                Console.WriteLine("El número " + numeroBuscar + " no se encuentra.");
            }
        }

        static int Busqueda(int[] arreglo, int numeroABuscar)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;

                if (arreglo[medio] == numeroABuscar)
                {
                    return medio; 
                }
                else if (arreglo[medio] < numeroABuscar)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }

            return -1; 
        }
    }
}
