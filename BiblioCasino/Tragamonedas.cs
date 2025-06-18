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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪");
            Console.WriteLine("▪      BIENVENIDO AL TRAGAMONEDAS     ▪");
            Console.WriteLine("▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("▪      Tres coincidencias:    X2      ▪");
            Console.WriteLine("▪      Cuatro coincidencias:  X3      ▪");
            Console.WriteLine("▪      Cinco coincidencias:   X4      ▪");
            Console.WriteLine("▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("            APUESTE!!!!!!!!            ");
            Console.ForegroundColor = ConsoleColor.White;
            int moneda = int.Parse(Console.ReadLine());
            if (moneda > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("***VAMOS, LA SUERTE ESTA CONTIGO***");
                Console.ForegroundColor = ConsoleColor.White;
                int PremioTotal = 0;
                for (int i = 0; i < 4; i++)
                {
                    PremioTotal = PremioTotal + filaspantalla(moneda);
                    Thread.Sleep(500);//pausa para evitar numeros aleatorios iguales
                }
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°");
                Console.WriteLine(" °       PREMIO MAYOR: " + PremioTotal + " SOLES          °");
                Console.WriteLine(" °°°°°°°°°°°°°°°°°(¬‿¬)°°°°°°°°°°°°°°°°°°°°");
                Console.ForegroundColor = ConsoleColor.Red;
                sonidogana();
                Console.WriteLine("\nPresiona una tecla para volver al Casino...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }
            else 
            {
                Console.WriteLine("ERROR!,Ingrese un monto valido ");
            }



        }
        public int filaspantalla(int moneda) 
        {
            string[] simbolos = { "CEREZA", "LIMON", "UVA", "CAMPANA", "7", "BAR" };
            Random rnd = new Random();
            int numsimbolos = 6;
            string[] resultado = new string[numsimbolos];//guardar los simbolos
            for (int i = 0; i < numsimbolos; i++)
            {
                resultado[i] = simbolos[rnd.Next(simbolos.Length)];
            }

            foreach (string leersimbolos in resultado) //leemos el resultado
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{leersimbolos,-8}| ");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(250); 
                Console.Beep(659, 120);

            }
            Console.WriteLine();
            //Aqui vemos cuantos simbolos se repiten
            int RepMax = 1;
            for (int x = 0; x < resultado.Length; x++)//Recorremos cada simbolo
            {
                int contar = 1;
                for (int i  = x + 1; i < resultado.Length; i++)//Comparamos
                {
                    if (resultado[x] == resultado[i])
                    {
                        contar++;
                    }
                }

                if (contar > RepMax)//Guardamos el numero de repeticiones
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
        static void sonidogana() 
        {
            Console.Beep(880, 150);  
            Console.Beep(988, 150); 
            Console.Beep(1047, 150); 
            Console.Beep(1175, 150); 
            Console.Beep(1319, 300);
            Thread.Sleep(100);
            Console.Beep(1047, 150);
            Console.Beep(1319, 300);
        }
    }
}
