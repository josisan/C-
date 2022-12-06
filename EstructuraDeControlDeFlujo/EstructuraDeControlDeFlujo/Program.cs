using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Activation;
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
            /* string carnet = "n";*/
            /*Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduce tu edad, por favor");
            int edad =  Int32.Parse(Console.ReadLine());*/
            /*if (edad >=18)
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
             }*/

            /*            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");

                        else
                        {
                            Console.WriteLine("Tienes Licencia?");

                            string carnet = Console.ReadLine();

                            int compara = String.Compare(carnet, "si", true);

                            if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                            else Console.WriteLine("Lo siento mucho, no puedes conducir");

                        }
             */

            /*Un programa donde se introduzca las notas de tres parciales, el alumno podra conseguir la media si pasa uno de los tres parciales*/

            /*Console.WriteLine("Introduce el primer parcial");
            double parcial1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Introduce el segundo parcial");
            double parcial2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Introduce el tercer parcial");
            double parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5)
                Console.WriteLine("La nota media es " + (parcial1 + parcial2 + parcial3) / 3);

            else Console.WriteLine("Vuelve en septiembre");*/

            /*Console.WriteLine("Introduce tu edad por favor: ");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");

            else if (edad >= 18 && edad <= 25) Console.WriteLine("Eres un adolecente");

            else if (edad > 25 && edad <= 60) Console.WriteLine("Eres una persona adulta, ve cuidando tu salud");

            else if (edad > 60 && edad <= 100) Console.WriteLine("Ya eres una persona mayor de edad, deberias cuidarte mucho");

            else if (edad > 100 && edad <= 120) Console.WriteLine("Eres una enciclopedia andante, estas viviendo años extras, te deseo lo mejor");

            else if (edad >= 121 && edad < 1000000) Console.WriteLine("Ya estamos en el paraiso?");

            else Console.WriteLine("Cuidate Mucho");*/





            /*............................................................ESTRUCTURA SWITCH.............................................................*/

            /*Console.WriteLine("Elige Medio de Transporte (carro, tren, avión)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "carro":
                    Console.WriteLine("Velocidad media: 100 km/h");
                    break;

                case "tre":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;

                case "avión":
                    Console.WriteLine("Velocidad media: 800 km//h");
                    break;

                default:
                    Console.WriteLine("Intente de nuevo");
                    break;
            }*/
            /*
                        Console.WriteLine("Introduce el numero de mes para cálculo de la comisión");

                        int nMes = Int32.Parse(Console.ReadLine());

                        switch (nMes)
                        {
                            case 1:
                                Console.WriteLine("Mes escogido: Enero");
                                break;

                            case 2:
                                Console.WriteLine("Mes escogido: Febrero");
                                break;

                            case 3:
                                Console.WriteLine("Mes escogido: Marzo");
                                break;

                            case 4:
                                Console.WriteLine("Mes escogido: Abril");
                                break;

                            case 5:
                                Console.WriteLine("Mes escogido: Mayo");
                                break;

                            case 6:
                                Console.WriteLine("Mes escogido: Junio");
                                break;

                            case 7:
                                Console.WriteLine("Mes escogido: Julio");
                                break;

                            case 8:
                                Console.WriteLine("Mes escogido: Agosto");
                                break;

                            case 9:
                                Console.WriteLine("Mes escogido: Septiembre");
                                break;

                            case 10:
                                Console.WriteLine("Mes escogido: Octubre");
                                break;

                            case 11:
                                Console.WriteLine("Mes escogido: Novimbre");
                                break;

                            case 12:
                                Console.WriteLine("Mes escogido: Diciembre");
                                break;

                            default:
                                Console.WriteLine("Esto no es una entrada valida, intente nuevamente");
                                break;*/


            /*.............................................Bucle While..............................................*/

            /*Console.WriteLine("Deseas entrar en el bucle while");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre, por favor");

                string nombre = Console.ReadLine();
                Console.WriteLine($"Hola {nombre}, saldras del Bucle cuando respondas 'no' a la pregunta siguiente");

                Console.WriteLine("Deseas repetir otra vez?");
                respuesta = Console.ReadLine();

            }
            Console.WriteLine("Has salido del Bucle While");*/

            /* Random numero = new Random();

             int aleatorio = numero.Next(0, 100);

             Console.WriteLine("Introduce el Numero Aleatorio");

             int num = 101;

             int intentos = 0;

             while (aleatorio != num)
             {
                 intentos++;

                 num = Int32.Parse(Console.ReadLine());
                 if (num > aleatorio) Console.WriteLine("El numero es mas bajo");

                 else if (num < aleatorio)
                 {
                     Console.WriteLine("El numero es mas alto");
                 }

             }
             Console.WriteLine("Has coincidido con el numero");
             Console.WriteLine($"La cantidad de veces que lo intentaste fueron {intentos} veces");
 */
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int minumero;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");



            do
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());
                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");

            }
            while (aleatorio != minumero);

            Console.WriteLine($"Has acertado en {intentos} intentos");
            
        
        }

    } 
}