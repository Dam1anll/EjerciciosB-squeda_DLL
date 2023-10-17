using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBúsqueda_DLL.Clases
{
    public class BusquedaLineal
    {
        public void BuscarNumeroEntero()
        {
            int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };

            Console.Write("Ingrese el número a buscar: ");
            int numeroBuscar = int.Parse(Console.ReadLine());

            int posicion = -1;

            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] == numeroBuscar)
                {
                    posicion = x;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroBuscar} se encuentra en la posición {posicion}.");
            }

            else 
            {
                Console.WriteLine($"El número {numeroBuscar} no se encuentra.");
            }
                
        }

        public void BuscarCadena()
        {
            string[] cadenas = { "Lamborgini", "Ferrari", "Buggati", "BMW", "Nissan" };

            Console.Write("Ingrese la cadena a buscar: ");
            string cadenaBuscar = Console.ReadLine();

            int indice = -1;

            for (int x = 0; x < cadenas.Length; x++)
            {
                if (cadenas[x] == cadenaBuscar)
                {
                    indice = x;
                    break;
                }
            }

            if (indice != -1) 
            {
                Console.WriteLine($"La cadena '{cadenaBuscar}' se encuentra en el índice {indice}.");
            }

            else 
            {
                Console.WriteLine($"La cadena '{cadenaBuscar}' no se encuentra.");
            }
               
        }

        public void BuscarNumeroPar()
        {
            int[] numeros = { 1, 3, 5, 4, 7, 8, 9, 11 };

            int indice = -1;

            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] % 2 == 0)
                {
                    indice = x;
                    break;
                }
            }

            if (indice != -1) 
            {
                Console.WriteLine($"El número par se encuentra en la posición {indice}.");
            }

            else 
            {
                Console.WriteLine("No se encontra el número par.");
            }
                
        }

        public void BuscarNumerosPares()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Posiciones de números pares:");

            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] % 2 == 0)
                {
                    Console.WriteLine($"Número par {numeros[x]} en la posición {x}");
                }
            }

            if (Array.Exists(numeros, x => x % 2 == 0) == false)
            {
                Console.WriteLine("No se encontraron números pares en la matriz.");
            }
        }
    }
}
