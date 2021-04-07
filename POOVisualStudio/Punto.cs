using System;

namespace POOVisualStudio
{
    class Punto
    {
        public Punto(int x, int y)
        {

            System.Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");

        }

        public Punto()
        {
            Console.WriteLine("Este es el constructor por defecto");
        }
    }
}