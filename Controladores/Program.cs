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
            CalculadoraInterfaz calcInt=new CalculadoraImplementacion();

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
                        calcInt.sumar();
                        break;
                    case 2:
                        calcInt.restar();
                        break;
                    case 3:
                        calcInt.multiplicar();
                        break;
                    case 4:
                        calcInt.dividir();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}
