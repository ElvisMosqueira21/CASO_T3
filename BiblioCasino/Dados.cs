using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Dados
    {

        public void Craps()
        {
            Console.Clear();
            Console.WriteLine("BIENVENIDO AL JUEGO DE DADOS MILLONARIOS");
            Console.WriteLine("REGLAS: Numeros Perder 2 , 3,  12 ");
            Console.WriteLine("        Numeros Ganar  4 , 5 , 6 ,7, 8 ,9 ,10 ,11");
            Console.WriteLine("Nuevo lanzamiento = Numeros Ganar, entonces GANAS ");
            Console.WriteLine("APUESTA X3 X3 X3 X3 X3");
            Console.WriteLine("DIGITA TU APUESTA");
            int apuesta = int.Parse(Console.ReadLine());    
            Console.WriteLine("Lanzando dados, 3 2 1 GO!");
            
            Random r = new Random();
            int Aleatorio = r.Next(2,13);
           
            int[] NumerosDados = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            if (Aleatorio == NumerosDados[0] || Aleatorio == NumerosDados[1] || Aleatorio == NumerosDados[10])
            {

                Console.WriteLine("NO TUVISTE LA COMBINACION IDEAL, Intentalo otra vez");
                Console.WriteLine("UPS, Intentalo de nuevo");
                Console.WriteLine("UPS, Intentalo de nuevo");

            }
            else
            {
                Console.WriteLine("FELICIDADES, TU APUESTA SE MULTIPLICO X3");
                apuesta = apuesta * 3;
                Console.WriteLine("GANASTE " + apuesta);

            }
            Console.WriteLine("\nPresione cualquier tecla para volver al casino:");
            Console.ReadKey();
            


        }

    }
}
