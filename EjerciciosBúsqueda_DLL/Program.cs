using EjerciciosBúsqueda_DLL.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBúsqueda_DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Busqueda Lineal
            BusquedaLineal busquedaLineal = new BusquedaLineal();
            busquedaLineal.BuscarNumeroEntero();


            //Busqueda Binaria
            BusquedaBinaria busquedaBinaria = new BusquedaBinaria();
            busquedaBinaria.BuscarNumeroMenorMayor();
        }
    }
}
