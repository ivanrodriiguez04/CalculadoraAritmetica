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
        public void sumar() 
        {
            Console.WriteLine("[INFO] - Ha seleccionado la opcion de sumar");
            int numero1=PedirNumeros();
            int numero2=PedirNumeros2();

            int suma=numero1 + numero2;

            Console.WriteLine("El resultado es: " + suma);
            
        }
        public void restar()
        {
            Console.WriteLine("[INFO] - Ha seleccionado la opcion de restar");
            int numero1 = PedirNumeros();
            int numero2 = PedirNumeros2();

            int resta = numero1 - numero2;

            Console.WriteLine("El resultado es: " + resta);

        }
        public void multiplicar()
        {
            Console.WriteLine("[INFO] - Ha seleccionado la opcion de multiplicar");
            int numero1 = PedirNumeros();
            int numero2 = PedirNumeros2();

            int multiplicacion = numero1 * numero2;

            Console.WriteLine("El resultado es: " + multiplicacion);

        }
        public void dividir()
        {
            Console.WriteLine("[INFO] - Ha seleccionado la opcion de dividir");
            int numero1 = PedirNumeros();
            int numero2 = PedirNumeros2();

            int division = numero1 / numero2;

            Console.WriteLine("El resultado es: " + division);

        }

        private int PedirNumeros()
        {
            int num1;
            Console.WriteLine("Indique el primer digito");
            num1 = Convert.ToInt32(Console.ReadLine());

            return num1;
        }

        private int PedirNumeros2()
        {
            int num2;
            Console.WriteLine("Indique el segundo digito");
            num2 = Convert.ToInt32(Console.ReadLine());

            return num2;
        }
    }
}
