using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasMetodos
{
    class Program
    {
        //El flujo de ejecucion es de arriba a abajo a expecion de que las variables esten en ambito de clase. A estas se le llama campos de clase.
        /*int numero1 = 5;

        int numero2 = 7;*/

        static void Main(string[] args)
        {
            /*mensajeEnPantalla();*/
            /*            Console.WriteLine(sumaNumeros2(2,3));*/
            int valor1 = 7;

            double valor2 = 5.2;

            double valor3 = 8.3;

            Console.WriteLine(Suma(valor1, valor2));

        }
         
        static double Suma(int num1, double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }

        static double Suma(int num1, double num2)
        {
            return num1 + num2;
        }

        /*static void mensajeEnPantalla()
        {

            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");

        }

        static void sumaNumeros(int num1, int num2)
        {
            

            Console.WriteLine("La suma de los numeros es: " + (num1+num2));
        }

        //Metodos Return


        static double sumaNumeros2(double num1, int num2) => num1 / num2;*/ //Si el resultado de la operacion es decimal, para que nos salgan los datos despues del punto, tenemos que especificar que sumaNumeros2 nos devuelva un double, y que uno de los parametros que se encuentran en el metodo sea double, pues etre un double y un int siempre será double.


        //Ambito y sobrecarga. video 12
        /*void primerMetodo()
        {
            

            Console.WriteLine(numero1 + numero2);
        }

        void segundoMetodo()
        {
            Console.WriteLine(numero1+numero2);
        }*/

        /*static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2 + numero3 + numero4;*/


    }
}
