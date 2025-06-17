using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioCasino;

namespace Proyecto_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int op;
            do
            {
                Console.Clear();
                Console.WriteLine("HOLA, BIENVENIDO AL CASINO");
                Console.WriteLine(" JUEGOS DE HOY: ");
                Console.WriteLine("1. TRAGAMONEDAS ");
                Console.WriteLine("2. RULETA ");
                Console.WriteLine("3. DADOS");
                Console.WriteLine("4. Blackjack(Veintiuno) ");
                Console.WriteLine("5. Adivina el numero ");
                Console.WriteLine("0. SALIR ");
                Console.WriteLine("INGRESA UN NUMERO PARA JUGAR: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Tragamonedas tragamon = new Tragamonedas();
                        tragamon.Tmonedas();
                        break;
                    case 2:
                        Ruleta laruleta = new Ruleta();
                        laruleta.ruleta();
                        break;
                    case 3:
                        Dados juegodados = new Dados();
                        juegodados.Craps();
                        break;
                    case 4:
                        Veintiuno juego = new Veintiuno();
                        juego.Jugar();
                        break;
                    case 5:
                        AdivinaNum adivinaNum = new AdivinaNum();
                        adivinaNum.NumeroAdivinado();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                        break;
                        
                       
                }

                Console.ReadKey();
                
            }
            while (op != 0);

            


        }
    }
}
