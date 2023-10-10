using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAritmetica.Servicios
{   
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// 09102023 -> irm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public  int MostrarMenuYOpcion() 
        {
            int opcionintroducida;

            Console.WriteLine("0. Cerrar Menu");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            opcionintroducida=Console.ReadKey(true).KeyChar - ('0');
            return opcionintroducida;
            
        }
    }
}
