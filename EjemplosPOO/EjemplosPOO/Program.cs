using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OBJETO miCirculo tiene como propiedades a pi, y como metodo a CalculoArea()

            /*            Circulo miCirculo; //creacion de objeto de tipo circulo. Varianle/Objeto de tipo circulo.
                        miCirculo = new Circulo(); //Iniciacion de Variable/Objeto de tipo Circulo. Instancias una Clase.
                                                   //Instanciacion. Ejemplarizacion. Creacion de ejemplar de clase.

                        Console.WriteLine(miCirculo.CalculoArea(5));

                        Circulo miCirculo2 = new Circulo();

                        Console.WriteLine(miCirculo2.CalculoArea(9));*/


                    //Intancia perteneciente a ConversorEuroDolar
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(-4.85);

            Console.WriteLine(obj.Convierte(50));


        }
    }

    class Circulo
    {
        //La constante pi no es necesario que salga de su ambito donde se ha declarado, pues realiza un calculo interno solamente. No debe ser accesible fuera de este ambito, por eso encapsulamos utilizamos la palabra reservada "private".
       private const double pi = 3.1416; //Propiedad de la clase Circulo, cuando definimos o declaramos variables dentro de una clase estas se convierten en propiedad, campo de clase.

        public double CalculoArea(int radio) //Metodo de clase, nos especifica que pueden hacer los objeto de tipo circulo, su comportamiento.
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.06;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        /*Si queremos modificar el valor del dato encapsulado lo recomendable es no hacerlo
         * desde una clase externa sino desde la misma, pues podemos utilizar condiciones,
         de esa manera manejamos el valor que se le vaya a dar desde otra clase*/
        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.06;
            else
                euro = nuevoValor;
        }

    }
     
}
