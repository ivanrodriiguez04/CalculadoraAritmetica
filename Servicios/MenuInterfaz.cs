using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y guarda la opcion seleccionada
        /// 09102023 -> irm
        /// </summary>
        /// <returns></returns>
        public int MostrarMenuYOpcion();
        /// <summary>
        /// Metodo en el se ejerce la funcion de sumar
        /// 10102023 -> irm
        /// </summary>
        public void sumar();
        /// <summary>
        /// Metodo en el se ejerce la funcion de restar
        /// 10102023 -> irm
        /// </summary>
        public void restar();
        /// <summary>
        /// Metodo en el se ejerce la funcion de multiplicar
        /// 10102023 -> irm
        /// </summary>
        public void multiplicar();
        /// <summary>
        /// Metodo en el se ejerce la funcion de dividir
        /// 10102023 -> irm
        /// </summary>
        public void dividir();






    }
}
