using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //Crear objeto/instancia de tipo coche.
            //dar un estado inicial a nuestro coche

            Coche coche2 = new Coche();
            
            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 1200.35);

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "Cuero");
            Console.WriteLine(coche3.getExtras());

        }

        
    }



    partial class Coche
    {

        //Constructor
        public Coche()
        {
            //Caracteristicas iniciales de nuestros coches;
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }

        //Sobre carga de constructor
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }

    }
    //---------------------------------------------------------------------------------------------------           
    partial class Coche
    {

        //Comportamientos o metodos

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;

        }
        public String getExtras()
        {
            return $"Extras del coche: \n Tapiceria: {tapiceria}\n Climatizador: {climatizador}\n";
        }

        //Metodo de acceso para cambiar valores fuera de la clase con condiciones
        public String getInfoCoche()
        {

            return $"Informacion del coche:\n Ruedas: {ruedas}\n Largo: {largo}\n Ancho: {ancho} \n";
        }


        //Caracteristicas o Propiedades

        private int ruedas;
        private double largo;
        private double ancho;
        //Solo si tiene o no tiene climatizador, true o false
        private bool climatizador;
        //Lo definimos como string porque queremos que el usuario nos diga la tapiceria: cuero, leader, etc;
        private String tapiceria;





    }
}
