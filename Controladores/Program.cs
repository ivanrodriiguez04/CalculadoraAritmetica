using CalculadoraAritmetica.Servicios;
using System.Diagnostics.CodeAnalysis;

namespace CalculadoraAritmetica.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 09102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 09102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos para utilizar los metodos
            MenuInterfaz menuInt = new MenuImplementacion();

            //Variables
            bool cerrarMenu = false;
            int opcionSeleccionada,num1,num2;

            //iniciamos el bucle while
            while (!cerrarMenu) 
            {
                opcionSeleccionada = menuInt.MostrarMenuYOpcion();
                switch (opcionSeleccionada) 
                {
                    case 0:
                        cerrarMenu = true;
                        Console.WriteLine("Saliendo de la aplicacion");
                        break;
                    case 1:
                        menuInt.sumar();
                        break;
                    case 2:
                        menuInt.restar();
                        break;
                    case 3:
                        menuInt.multiplicar();
                        break;
                    case 4:
                        menuInt.dividir();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}
