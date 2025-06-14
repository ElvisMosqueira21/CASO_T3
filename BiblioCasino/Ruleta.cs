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
            Console.WriteLine("             ¡Bienvenido a la Ruleta de Casino!              ");
            Console.WriteLine("-------Verde: PIERDE--ROJO: X2--NEGRO: X4");
            Console.WriteLine("----------------------Apuesta YA------------------------");
            int recompensa = int.Parse(Console.ReadLine());
            Random random = new Random();
            string[] colores = { "Rojo", "Negro", "Verde" };
            int numero = random.Next(0, 37); // Números del 0 al 36
            string color;
            // El número 0 es Verde; el resto alterna entre Rojo y Negro
            if (numero == 0 || numero == 1 || numero==3 || numero==5)
            {
                color = "Verde";
                Console.WriteLine(" Intenta de nuevo :(");
                
            }
            else if (numero % 2 == 0)
            {
                color = "Negro";
                Console.WriteLine("GANASTE!!!!!!, Apuesta x 4 ");
                Console.WriteLine("GANASTE :"+ (recompensa*4));
            }
            else
            {
                color = "Rojo";
                Console.WriteLine("GANASTE!!!!!!, Apuesta x 2 ");
                Console.WriteLine("GANASTE :" + (recompensa * 2));
            }

            Console.WriteLine($"La bola cayó en: {color} {numero}");
            Console.WriteLine("¡Gracias por jugar!");
            Console.WriteLine("\nPresione cualquier tecla para volver  al Casino");
            Console.ReadKey();
        }
    }
}
