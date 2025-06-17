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
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("+                                                             +");
            Console.WriteLine("+        BIENVENIDO AL JUEGO DE LOS 2DADOS MILLONARIOS        +");
            Console.WriteLine("+                                                             +");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("REGLAS: SUMA DE DADOS que pierdes: 2 , 3,  12                  ");
            Console.WriteLine("        SUMA DE DADOS que ganas  : 4 , 5 , 6 ,7, 8 ,9 ,10 ,11  ");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("+                APUESTA X3 X3 X3 X3 X3                       +");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("***************** DIGITA TU APUESTA***************************+");
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            int apuesta = int.Parse(Console.ReadLine());    
            Console.WriteLine("                Lanzando dados, 3 2 1 GO!                      ");
            
            Random r = new Random();
            int Aleatorio = r.Next(2,13);
           
            int[] NumerosDados = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            if (Aleatorio == NumerosDados[0] || Aleatorio == NumerosDados[1] || Aleatorio == NumerosDados[10])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("    NO TUVISTE LA COMBINACION IDEAL, Intentalo otra vez");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                UPS, Intentalo de nuevo            ");
                Console.WriteLine("                UPS, Intentalo de nuevo            ");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("        FELICIDADES, TU APUESTA SE MULTIPLICO X3");
                Console.ForegroundColor = ConsoleColor.White;
                apuesta = apuesta * 3;
                Console.WriteLine("             GANASTE " + apuesta);

            }
            Console.WriteLine("           \nPresione cualquier tecla para volver al casino:             ");
            Console.ReadKey();
            


        }

    }
}
