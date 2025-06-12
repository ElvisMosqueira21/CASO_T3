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
            filaspantalla(moneda);
            Thread.Sleep(1000);
            filaspantalla(moneda);
            Thread.Sleep(1000);
            filaspantalla(moneda);
            Thread.Sleep(1000);
            filaspantalla(moneda);


   
        }
        public void filaspantalla(int moneda) 
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

            // Mostramos el premio
            if (RepMax == 3)
            {
                Console.WriteLine("FELICIDADES, GANASTE: " + (moneda * 2));
            }
            else if (RepMax == 4)
            {
                Console.WriteLine("FELICIDADES, GANASTE: " + (moneda * 3));
            }
            else if (RepMax == 5)
            {
                Console.WriteLine("FELICIDADES, GANASTE: " + (moneda * 4));
            }
            else 
            {
                Console.WriteLine("Sigue intentando, la proxima apuesta es tuya!");
            }

        }
    }
}
