using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeControlDeFlujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                    operadores de comparación

                   operador          Significado

                     ==...............igual que
                     !=...............Diferente que
                     <................Menor que
                     <=...............Menor o Igual que 
                     >................Mayor que
                     >=...............Mayor o igual que

                     operadores Logicos

                     operador        significado

                       &&............Y logico
                       ||............O logico


           */
            /*int edad = 15;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if(edad >= 18)
            {
                Console.WriteLine("Adelante, Eres Mayor de edad");
            }*/

            /*Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            bool carnet = false;

            if (carnet)
            {
                Console.WriteLine("Puedes Conducir vehiculos");
            }
            else
            {
                Console.WriteLine("Lo siento pero no puedes conducir vehiculos");

            }*/
            string carnet = "n";
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");
            int edad =  Int32.Parse(Console.ReadLine());
            if (edad >=18)
             {
                Console.WriteLine("Tienes Licencia de conducir? (y/n)");
                carnet = Console.ReadLine();
             }
          
            if (edad >= 18 && carnet == "y")
             {
                Console.WriteLine("Puedes conducir un Vehiculo");
             }
            else
             {
                    Console.WriteLine("No puedes conducir un vehiculo");
             }
            
            
 
        }
    }
}
