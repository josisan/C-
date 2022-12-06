using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeEdad
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a Calcular Su edad");
            Console.WriteLine("Ingrese el Dia de su nacimiento: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el mes: ");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ahora el año: ");
            int y = Int32.Parse(Console.ReadLine());

            DateTime fechaDeNacimiento = new DateTime(y, m, d);
            /*int edadEnYears = (DateTime.Now - fechaDeNacimiento);
            int edadEnDias = ((DateTime.Now - fechaDeNacimiento)).Days;*/
            /*int edadEnMeses = ((DateTime.Now - fechaDeNacimiento));
            int edadEnMinutos = ((DateTime.Now - fechaDeNacimiento)).Days;*/
            int uno = DateTime.Now.Year - fechaDeNacimiento.Year;
            int dos = uno - fechaDeNacimiento.Year;
            Console.WriteLine(dos);

        }
    }
}/*.ToString("dd/MM/yyyy")*/