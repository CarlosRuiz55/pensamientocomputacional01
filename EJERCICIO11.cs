+using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int vluz;
            vluz = 300000;
            double distancia;
            double tiempo;

            Console.WriteLine("Introduzca el tiempo en segundos: ");
            tiempo = double.Parse(Console.ReadLine());
            distancia = vluz * tiempo;
            Console.WriteLine("La distancia recorrida en dicho tiempo es de: " + distancia);
            Console.ReadKey();
            

            
        }
    }
}
