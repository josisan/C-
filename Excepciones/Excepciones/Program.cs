using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int miNumero;
            int intentos = 0;
            Console.WriteLine("Introduzca un numero entre 0 y 100, trata de hacerlo en 5 intentos, si no, pierdes");

            do
            {
                intentos++;
                try
                {
                   miNumero = int.Parse(Console.ReadLine());

                }
                /*catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto");
                    miNumero = 0;
                }*/
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error, se toma como numero introducido el 0.");
                    miNumero = 0;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Ha introducido un error");

                    miNumero = 0;
                }
                

                if (miNumero > aleatorio) Console.WriteLine("El numero es mas bajo");
                if (miNumero < aleatorio) Console.WriteLine("El numero es mas alto");


            } while (miNumero != aleatorio);

            if (intentos <= 6) Console.WriteLine($"Ha acertado en {intentos} intentos y has ganado");
            else Console.WriteLine($"Has acertado en {intentos} intentos y por eso has perdido");
        }
    }
}
