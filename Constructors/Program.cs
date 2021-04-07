using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Coche choche1= new Coche(4500.25, 1200.35);
            choche1.setExtras(true, "cuero");
            System.Console.WriteLine(choche1.getInfoCoche());
            System.Console.WriteLine(choche1.getExtras());

            System.Console.WriteLine();

            Coche choche2= new Coche();
            choche2.setExtras(true, "marmol");
            System.Console.WriteLine(choche2.getInfoCoche());
            System.Console.WriteLine(choche2.getExtras());



        }
    }

    class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private string tapiceria;


        public Coche()
        {

            ruedas= 4;
            largo =2300.5;
            ancho= 0.800;
            tapiceria = "Tela";

        }

        public Coche(double largoC, double AnchoC)
        {
            ruedas= 4;
            largo= largoC;
            ancho= AnchoC;
            tapiceria = "Tela";

        }

        public string getInfoCoche()
        {
            return "Informacion del coche: \n "+"Ruedas: "+ruedas + " Largo:"+largo +" Ancho:"+ ancho;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador= climatizador;

            this.tapiceria= tapiceria;

        }

        public string getExtras()
        {
            return "Extras del coche: \n"+ "Tapiceria: "+tapiceria+" Climatizador:"+climatizador;
        }



    }
}
