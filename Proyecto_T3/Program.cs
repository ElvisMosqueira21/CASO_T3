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
                        Console.WriteLine("Ruleta no está implementado aún.");
                        break;
                    case 3:
                        Console.WriteLine("Dados no está implementado aún.");
                        break;
                    case 4:
                        Console.WriteLine("Blackjack no está implementado aún.");
                        break;
                    case 5:
                        Console.WriteLine("Adivina el número no está implementado aún.");
                        break;
                    case 0:
                        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                Console.ReadKey();
                
            }
            while (op != 0);

            


        }
    }
}
