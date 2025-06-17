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

            Console.Clear();
            float apuesta = 0;
            Random random = new Random();
            float Valor = 0;
            int opcion;
            Console.WriteLine("BIENVENIDO AL JUEGO : ADIVINA EL NÚMERO ");
            Console.WriteLine("Ingrese el monto a APOSTAR!: ");
            apuesta = int.Parse(Console.ReadLine());
            if (apuesta > 0)
            {

                do
                {
                    Console.WriteLine("Elija el Rango de su número de la Suerte🍀");
                    Console.WriteLine("1. Solo números de ((1 - 10)) -> [X2]");
                    Console.WriteLine("2. Solo números de ((1 - 20)) -> [X4]");
                    Console.WriteLine("3. Solo números de ((1 - 50)) -> [x6]");
                    Console.WriteLine("4. Adivina vocales!! ((a, e, i ,o ,u))");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese su NÚMERO de la SUERTE🍀 (1-10)");
                            int Numero1 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 10);
                            if (Numero1 > 0 & Numero1 < 10)
                            {
                                if (Valor == Numero1)
                                {
                                    Console.WriteLine("FELICIDADES USTED HA GANADO X2!!!");
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
                            Console.WriteLine("Ingrese su NÚMERO de la SUERTE🍀 (1-20)");
                            int Numero2 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 20);
                            if (Numero2 > 0 & Numero2 < 20)
                            {
                                if (Valor == Numero2)
                                {
                                    Console.WriteLine("FELICIDADES USTED HA GANADO X4!!!");
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

                            Console.WriteLine("Ingrese su NÚMERO de la SUERTE🍀 (1-50)");
                            int Numero3 = int.Parse(Console.ReadLine());
                            Valor = random.Next(1, 50);
                            if (Numero3 > 0 & Numero3 < 50)
                            {
                                if (Valor == Numero3)
                                {
                                    Console.WriteLine("FELICIDADES USTED HA GANADO X6!!!");
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

                            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
                            char VocalOculta = vocales[random.Next(vocales.Length)];
                            Console.WriteLine("ADIVINA LA VOCAL CORRECTA!!:");
                            Console.WriteLine("Ingrese Su VOCAL de la SUERTE🍀 (a, e, i ,o , u)");

                            char Ingresado = Console.ReadKey().KeyChar;
                            if (vocales.Contains(Ingresado))
                            {
                                if (Ingresado == VocalOculta)
                                {
                                    Console.WriteLine("FELICIDADES ACERTASTE LA VOCAL CORRECTA!! ");
                                    Console.WriteLine("GANASTE (X2)");
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
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Ingrese una opción correcta....");

                            break;
                    }


                }
                while (opcion != 4);
            }
            else
            {
                Console.WriteLine("Ingrese un Monto mayor");
            }
            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
