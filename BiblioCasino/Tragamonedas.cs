using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Tragamonedas
    {
        
        public void Tmonedas() 
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL TRAGAMONEDAS");
            Console.WriteLine("Tres coincidencias:    X2 ");
            Console.WriteLine("Cuatro coincidencias:  X3 ");
            Console.WriteLine("Cinco coincidencias:   X4 ");
            Console.WriteLine("APUESTE!!!!!!!!");
            int moneda = int.Parse(Console.ReadLine());
            Console.WriteLine("VAMOS, LA SUERTE ESTA CONTIGO");

            int PremioTotal = 0;
            for (int i = 0; i < 4; i++)
            {
                PremioTotal = PremioTotal+filaspantalla(moneda);
                Thread.Sleep(500);
            }
            Console.WriteLine("PREMIO MAYOR: " + PremioTotal + " SOLES" );

            Console.WriteLine("\nPresiona una tecla para volver al Casino...");
            Console.ReadKey();



        }
        public int filaspantalla(int moneda) 
        {
            string[] simbolos = { "CEREZA", "LIMON", "UVA", "CAMPANA", "7", "BAR" };
            Random rnd = new Random();
            int numsimbolos = 6;
            string[] resultado = new string[numsimbolos];
            for (int i = 0; i < numsimbolos; i++)
            {
                resultado[i] = simbolos[rnd.Next(simbolos.Length)];
            }

            foreach (string leersimbolos in resultado)
            {

                Console.Write($"{leersimbolos,-8}| ");

            }
            Console.WriteLine();
            //Aqui vemos cuantos simbolos se repiten
            int RepMax = 1;
            for (int x = 0; x < resultado.Length; x++)
            {
                int contar = 1;
                for (int i  = x + 1; i < resultado.Length; i++)
                {
                    if (resultado[x] == resultado[i])
                    {
                        contar++;
                    }
                }

                if (contar > RepMax)
                {
                    RepMax = contar;
                }
            }

            // Mostramos el premio,segun las repeticiones
            int premio = 0;
            if (RepMax == 3)
            {
                premio = moneda * 2;
                Console.WriteLine("FELICIDADES, GANASTE: " + (premio));
            }
            else if (RepMax == 4)
            {
                premio = moneda * 3;
                Console.WriteLine("FELICIDADES, GANASTE: " + (premio));
            }
            else if (RepMax == 5)
            {
                premio = moneda * 4;
                Console.WriteLine("FELICIDADES, GANASTE: " + (premio));
            }
            else 
            {
                Console.WriteLine("Sigue intentando, la proxima apuesta es tuya!");
            }
            return premio;

        }
    }
}
