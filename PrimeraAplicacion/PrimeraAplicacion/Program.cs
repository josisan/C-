using System; //System,  entender esto como un namespace o un almacen de clases por defecto, como son Console de Console.WriteLine entre otras.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion //Esto tambien es un almacen de clases pero creado por nosotros se puede decir.
{
    internal class Program
    {
        static void Main(string[] args)//C# es Case Senssitive, si escribimos el 'Main' como 'main' no lo reconocería.
        {
            /*Console.WriteLine("Bienvenu to this Course");*/ /*Esto imprime mensaje en consola*/

            /*int edad = 24;

            Console.WriteLine("Tengo la edad de " + ++edad + " años");
*/
            /*int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona3);*/

            //No se puede lo siguiente porque a todas se le declara, sin embargo solo edadPersona4 toma el valor:
            /*int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;

                Console.WriteLine(edadPersona4);
*/
            //Declaracion implicita de variables es permitido en c#, pero hay que tener cuidado porque lo pueden confundir con visual basic

            //en ves de utilizar int para un entero podemos dejas que c# le asigne el tipo de datos que es:

            /*var edadPersona = 27;

            *//*Console.WriteLine(edadPersona);*//*

            //La desventaja es que no podemos asignarle otro valor a la variable mas adelante:

            edadPersona = 27.5;

            Console.WriteLine(edadPersona);*/

            //Casting o conversion explicita

            /*double temperatura = 34.9;
            int temperaturaDom;

            temperaturaDom =(int) temperatura;

            Console.WriteLine(temperaturaDom);*/


            //Conversion implicita
            /*int habitantesTierra = 800000000;

            long habitantesTierra2022 = habitantesTierra;

            float pesoMaterial = 5.78F; //las variables de tipo float siempre llevan el sufijo F despues del numero para indicar que son tipo float

            double pesoMaterialPrec = pesoMaterial;

            Console.WriteLine(pesoMaterialPrec);*/

            /*    Console.WriteLine("Introduce el primer numero");

                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el segundo numero");
                int num2 = int.Parse(Console.ReadLine());

                int resultadoSum = num1 + num2;
                int resultadoRes = num1 - num2;
                int resultadoMul = num1 * num2;
                int resultadoDiv = num1 / num2;
                int resultadoSus = num1 % num2;

                Console.WriteLine("Las operaciones aritmeticas de los numeros " + num1 + " y " + num2 + " son las siguientes:");
                Console.WriteLine("Suma: " +  resultadoSum);
                Console.WriteLine("Resta: " + resultadoRes);
                Console.WriteLine("Multiplicación: " + resultadoMul);
                Console.WriteLine("Divición: " + resultadoDiv);
                Console.WriteLine("Residuo: " + resultadoSus);
    */
            /*            Console.WriteLine("Acabas de introducir el numero: " + num1);
            */


            /*const int VALOR = 24;

            const int VALOR2 = 27;

            //Otra forma de utilizar un WriteLine-->
            Console.WriteLine("El valor de las constantes son: {0} y {1}", VALOR, VALOR2);
*//*
            const double PI = 3.1416;

            Console.WriteLine("Introduzca la medida del Radio: ");

            double radio =double.Parse( Console.ReadLine());

            //El calculo del area es PI*r al cuadrado, podemos utilizar el metodo Math.Pow que se refiere a potencia, esto recibe 2 parametros, la base y el exponente.
            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine("El area del circulo es: {0}", area);

*/

            //Metodos sin parametros

            /*int sumaNumeros(){
                int num1 = 40;
                int num2 = 80;
                int result = num1 + num2;
                return result;
            }*/

            //Metodos con parametros

            int sumaNumeros(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
            }
            sumaNumeros(3, 5);

            //Metodo que no devuelve ningun valor:
            //un metodo que lleva la palabra reservada "void" jamas llevara la instruccion return.
            /*void sumaNumeros()
            {
                int num1 = 7;
                int num2 = 10;

                int result = num1 + num2;
                Console.WriteLine(result);
            }

            sumaNumeros();
*/






        }
    }
}
