using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class AdivinaNum
    {
        public void NumeroAdivinado()
        {

            float apuesta = 0;
            Random random = new Random();
            float Valor = 0;
            int opcion;
            Console.WriteLine("╔═════════════════════════════════════════╗");
            Console.WriteLine("║ BIENVENIDO AL JUEGO : ADIVINA EL NÚMERO ║");
            Console.WriteLine("╚═════════════════════════════════════════╝");
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("  Ingrese el monto a APOSTAR!:  ");
            Console.WriteLine("╚══════════════════════════════╝");
            apuesta = float.Parse(Console.ReadLine());
            if (apuesta > 0)
            {
                Console.Clear();
                do
                {
                    Console.WriteLine("╔══════════════════════════════════════════════╗");
                    Console.WriteLine("║  Elija el Rango de su número de la Suerte🍀  ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine("║  1. Solo números de ((1 - 10)) -> [X2]       ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine("║  2. Solo números de ((1 - 20)) -> [X4]       ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine("╠  3. Solo números de ((1 - 50)) -> [x6]       ║");
                    Console.WriteLine("╠══════════════════════════════════════════════╣");
                    Console.WriteLine("║  4. Adivina vocales!! ((a, e, i ,o ,u))      ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╣");
                    Console.WriteLine("║  5. Salir                                    ║");
                    Console.WriteLine("╚══════════════════════════════════════════════╝");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" ╔═════════════════════════════════════════╗");
                            Console.WriteLine("║  Ingrese su NÚMERO de la SUERTE🍀 (1-10)  ║");
                            Console.WriteLine(" ╚═════════════════════════════════════════╝");
                            int Numero1 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 11);
                            if (Numero1 > 0 & Numero1 < 11)
                            {
                                if (Valor == Numero1)
                                {
                                    Console.WriteLine("═════════════════════════════════════");
                                    Console.WriteLine("  FELICIDADES USTED HA GANADO X2!!!  ");
                                    Console.WriteLine("═════════════════════════════════════");
                                    apuesta = apuesta * 2;
                                    Console.WriteLine("PREMIO::: " + apuesta);
                                }
                                else
                                {
                                    Console.WriteLine("Vaya, parece que la suerte no está de tu lado 😔");
                                    Console.WriteLine("El numero era: " + Valor);
                                    Console.WriteLine("Intenta de nuevo!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número correcto...");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine(" ╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ Ingrese su NÚMERO de la SUERTE🍀 (1-20)   ║");
                            Console.WriteLine(" ╚═════════════════════════════════════════╝");
                            int Numero2 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 21);
                            if (Numero2 > 0 & Numero2 < 21)
                            {
                                if (Valor == Numero2)
                                {
                                    Console.WriteLine("═════════════════════════════════════");
                                    Console.WriteLine("  FELICIDADES USTED HA GANADO X4!!!  ");
                                    Console.WriteLine("═════════════════════════════════════");
                                    apuesta = apuesta * 4;
                                    Console.WriteLine("PREMIO::: " + apuesta);
                                }
                                else
                                {
                                    Console.WriteLine("Vaya, parece que la suerte no está de tu lado 😔");
                                    Console.WriteLine("El numero era: " + Valor);
                                    Console.WriteLine("Intenta de nuevo!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número correcto...");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(" ╔═════════════════════════════════════════╗");
                            Console.WriteLine("║ Ingrese su NÚMERO de la SUERTE🍀 (1-50)   ║");
                            Console.WriteLine(" ╚═════════════════════════════════════════╝");
                            int Numero3 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 51);
                            if (Numero3 > 0 & Numero3 < 51)
                            {
                                if (Valor == Numero3)
                                {
                                    Console.WriteLine("═════════════════════════════════════");
                                    Console.WriteLine("  FELICIDADES USTED HA GANADO X6!!!  ");
                                    Console.WriteLine("═════════════════════════════════════");
                                    apuesta = apuesta * 6;
                                    Console.WriteLine("PREMIO::: " + apuesta);
                                }
                                else
                                {
                                    Console.WriteLine("Vaya, parece que la suerte no está de tu lado 😔");
                                    Console.WriteLine("El numero era: " + Valor);
                                    Console.WriteLine("Intenta de nuevo!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese un número correcto...");
                            }
                            break;
                        case 4:
                            Console.Clear();
                            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
                            //                  0    1    2    3    4    
                            char VocalOculta = vocales[random.Next(vocales.Length)];
                            //seleccíonará una posición de la matriz y elegirá la vocal que responde a ese lugar
                            Console.WriteLine(" ╔════════════════════════════════════╗");
                            Console.WriteLine("║    ADIVINA LA VOCAL CORRECTA!!:      ║");
                            Console.WriteLine(" ╚════════════════════════════════════╝");
                            Console.WriteLine("╔════════════════════════════════════════════════════╗");
                            Console.WriteLine("║  Ingrese Su VOCAL de la SUERTE🍀 (a, e, i ,o , u)  ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════╝");

                            char Ingresado = char.Parse(Console.ReadLine());
                            if (vocales.Contains(Ingresado))
                            {
                                if (Ingresado == VocalOculta)
                                {
                                    Console.WriteLine("════════════════════════════════════════════");
                                    Console.WriteLine("  FELICIDADES ACERTASTE LA VOCAL CORRECTA!! ");
                                    Console.WriteLine("                GANASTE (X2)                ");
                                    Console.WriteLine("════════════════════════════════════════════");
                                    apuesta = apuesta * 2;
                                    Console.WriteLine("PREMIO::: " + apuesta);
                                }
                                else
                                {
                                    Console.WriteLine("\nVaya, parece que la suerte no está de tu lado 😔");
                                    Console.WriteLine("La vocal era: " + VocalOculta);
                                    Console.WriteLine("Intenta de nuevo!!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ingrese la vocal correcta...");
                            }

                            break;
                        case 5:
                            Console.WriteLine("Saliendo....");

                            break;
                        default:
                            Console.WriteLine("Ingrese una opción correcta....");

                            break;
                    }


                }
                while (opcion != 5);
            }
            else
            {
                Console.WriteLine("Ingrese un Monto mayor");
            }
            Console.WriteLine("\nPresione una tecla para salir");

        }   
    }
}
