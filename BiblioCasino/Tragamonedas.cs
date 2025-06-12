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
            Console.WriteLine("Introduzca la moneda/billete");
            int moneda = int.Parse(Console.ReadLine());
            Console.WriteLine("VAMOS, LA SUERTE ESTA CONTIGO");
            filaspantalla();
            Thread.Sleep(1000);
            filaspantalla();
            Thread.Sleep(1000);
            filaspantalla();
            Thread.Sleep(1000);
            filaspantalla();

   
        }
        public void filaspantalla() 
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
        }
    }
}
