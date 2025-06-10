using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Tragamonedas
    {
        public void Tmonedas() 
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDOS AL TRAGAMONEDAS");
            Console.WriteLine("Tres coincidencias:    X2 ");
            Console.WriteLine("Cuatro coincidencias:  X3 ");
            Console.WriteLine("Cinco coincidencias:   X4 ");
            Console.WriteLine("Introduzca la moneda/billete");
            int moneda = int.Parse(Console.ReadLine());
            Console.WriteLine("VAMOS, LA SUERTE ESTA CONTIGO");
            string[] simbolos = { "CEREZA", "LIMON", "UVA", "CAMPANA", "7", "BAR" };
            Random rnd = new Random();

            string simbolo1 = simbolos[rnd.Next(simbolos.Length)];
            string simbolo2 = simbolos[rnd.Next(simbolos.Length)];
            string simbolo3 = simbolos[rnd.Next(simbolos.Length)];

            Console.WriteLine($"| {simbolo1} | {simbolo2} | {simbolo3} |\n");

            if (simbolo1 == simbolo2 && simbolo2 == simbolo3)
            {
                Console.WriteLine(" ¡Jackpot! ¡Los 3 símbolos son iguales!");
            }
            else if (simbolo1 == simbolo2 || simbolo1 == simbolo3 || simbolo2 == simbolo3)
            {
                Console.WriteLine(" ¡Has acertado 2 símbolos! Ganaste un premio menor.");
            }
            else
            {
                Console.WriteLine(" No hay coincidencias. ¡Suerte la próxima!");
            }

            Console.WriteLine("\nPresiona una tecla para volver al menú...");
            Console.ReadKey();




        }
    }
}
