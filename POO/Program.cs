using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo;// creación de objecto

            miCirculo = new Circulo(); //Iniciacion de variable objecto
            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2= new Circulo();
            Console.WriteLine(miCirculo.calculoArea(9));
        
        }

    }

    class Circulo 
    {

        const double pi= 3.1416;  //propiedad de la clase circulo, Campos de clases


        public double calculoArea(int radio) // método de clase. que pueden hacer los objectos de tipo circulo
        {

            return pi * radio * radio;



        }

    }
}
