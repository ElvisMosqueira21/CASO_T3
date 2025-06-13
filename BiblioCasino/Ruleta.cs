using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Ruleta
    {
        public void ruleta() 
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido a la Ruleta de Casino!");

            Random random = new Random();
            string[] colores = { "Rojo", "Negro", "Verde" };
            int numero = random.Next(0, 37); // Números del 0 al 36
            string color;

            // El número 0 es Verde; el resto alterna entre Rojo y Negro
            if (numero == 0)
            {
                color = "Verde";
            }
            else if (numero % 2 == 0)
            {
                color = "Negro";
            }
            else
            {
                color = "Rojo";
            }

            Console.WriteLine($"La bola cayó en: {color} {numero}");
            Console.WriteLine("¡Gracias por jugar!");
            Console.WriteLine("\nPresione cualquier tecla para volver  al Casino");
            Console.ReadKey();
        }
    }
}
