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
                Console.ReadKey();
            }
            while (op != 0);

            Tragamonedas tragamon = new Tragamonedas();
            tragamon.Tmonedas();


        }
    }
}
