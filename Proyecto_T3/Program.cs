using BiblioCasino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto_T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int op;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░BIENVENIDOS AL CASINO░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("︽≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣≣︽");
                Console.WriteLine("ㅐ               JUEGOS DE HOY              ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 1.        TRAGAMONEDAS              ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 2.           RULETA                 ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 3.           DADOS                  ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 4.      Blackjack(Veintiuno)        ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 5.       Adivina el numero          ㅐ");
                Console.WriteLine("ㅐ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ㅐ");
                Console.WriteLine("ㅐ    ◉ 0.            SALIR                 ㅐ");
                Console.WriteLine("ㅐ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ㅐ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("        INGRESA UN NUMERO PARA JUGAR:         ");
                Console.ForegroundColor = ConsoleColor.White;
                op = int.Parse(Console.ReadLine());
                Console.Beep(1000,400);
                tono();

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
                        Console.WriteLine("Gracias por jugar.Hasta la próxima");
                        break;
                        
                       
                }

                Console.ReadKey();
                
            }
            while (op != 0);

            


        }
        static void tono() 
        {
            Console.Beep(659, 120);
            Console.Beep(758, 120);
            Console.Beep(880, 120);
            Console.Beep(987, 120);
            Console.Beep(1046, 120);
            Console.Beep(1175, 120);
            Console.Beep(1318, 120);
            Console.Beep(880, 120 * 2);
           
        }
    }
}
