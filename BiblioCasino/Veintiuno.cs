using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Veintiuno
    {

        private class PlayingCard
        {

            public string Palo;
            public int Valor;
            public int Puntos;

            public PlayingCard(int s, int v)
            {
                Valor = v;
                switch (s)
                {
                    case 1:
                        Palo = "♣";
                        break;
                    case 2:
                        Palo = "♦";
                        break;
                    case 3:
                        Palo = "♥";
                        break;
                    case 4:
                        Palo = "♠";
                        break;
                    default:
                        Palo = "";
                        break;
                }

                Puntos = (Valor > 10) ? 10 : (Valor == 1 ? 11 : Valor);
            }
        }
        private class Player
        {
            public PlayingCard[] mano = new PlayingCard[5];
            public int cartasEnMano = 0;
            public int puntos = 0;
            public string name;
        }

        private PlayingCard[] baraja;
        private int puntero = 0;

        public Veintiuno()
        {
            baraja = GenerarBaraja();
            MezclarBaraja(ref baraja);
        }

        public void Jugar()
        {
            string jugarOtraVez;
            string nombreJugador = "";

            do
            {
                puntero = 0;
                baraja = GenerarBaraja();
                MezclarBaraja(ref baraja);

                Player jugador = new Player();
                Console.Write("Por favor, introduce tu nombre: ");
                jugador.name = Console.ReadLine();
                nombreJugador = jugador.name;

                Player crupier = new Player();
                Console.Write("Por favor, introduce el nombre del crupier: ");
                crupier.name = Console.ReadLine();

                RobarCarta(ref jugador);
                RobarCarta(ref jugador);
                VerificarAses(ref jugador);
                MostrarMano(jugador);
                bool jugadorVivo = VerificarPuntos(jugador);

                while (jugadorVivo)
                {
                    Console.Write("¿Pedir carta o Plantarse? (Hit/Stick): ");
                    string eleccion = Console.ReadLine().ToUpper();
                    if (eleccion == "HIT")
                    {
                        RobarCarta(ref jugador);
                        VerificarAses(ref jugador);
                        MostrarMano(jugador);
                        jugadorVivo = VerificarPuntos(jugador);
                    }
                    else if (eleccion == "STICK")
                    {
                        break;
                    }
                }

                if (jugadorVivo)
                {
                    Console.WriteLine("\n*** Turno del Crupier ***");
                    RobarCarta(ref crupier);
                    RobarCarta(ref crupier);
                    VerificarAses(ref crupier);
                    MostrarMano(crupier);
                    bool crupierVivo = VerificarPuntos(crupier);

                    while (crupierVivo && crupier.puntos < 17 && crupier.cartasEnMano < 5)
                    {
                        Console.WriteLine("El crupier pide una carta...");
                        Console.ReadLine();
                        RobarCarta(ref crupier);
                        VerificarAses(ref crupier);
                        MostrarMano(crupier);
                        crupierVivo = VerificarPuntos(crupier);
                    }

                    if (crupier.puntos >= 17 && crupier.puntos <= 21)
                    {
                        Console.WriteLine("El crupier se planta.");
                    }
                }

                CalcularGanador(jugador, crupier);

                Console.Write("¿Quieres jugar de nuevo? (Y/N): ");
                jugarOtraVez = Console.ReadLine().ToUpper();

            } while (jugarOtraVez == "Y");

            Console.WriteLine($"\nGracias por jugar, {nombreJugador}. ¡Hasta la próxima!");
        }



        private PlayingCard[] GenerarBaraja()
        {
            PlayingCard[] baraja = new PlayingCard[52];
            int contador = 0;
            for (int palo = 1; palo < 5; palo++)
            {
                for (int valor = 1; valor < 14; valor++)
                {
                    baraja[contador++] = new PlayingCard(palo, valor);
                }
            }
            return baraja;
        }

        private void MezclarBaraja(ref PlayingCard[] baraja)
        {
            Random rnd = new Random();
            for (int i = 0; i < baraja.Length; i++)
            {
                int r = rnd.Next(baraja.Length);
                var temp = baraja[i];
                baraja[i] = baraja[r];
                baraja[r] = temp;
            }
        }

        private void RobarCarta(ref Player jugador)
        {
            PlayingCard siguienteCarta = baraja[puntero++];
            if (jugador.cartasEnMano < 5)
            {
                jugador.mano[jugador.cartasEnMano++] = siguienteCarta;
                jugador.puntos += siguienteCarta.Puntos;
            }
        }

        private bool VerificarPuntos(Player jugador)
        {
            if (jugador.puntos > 21)
            {
                Console.WriteLine("¡Te pasaste!");
                return false;
            }
            return true;
        }

        private void VerificarAses(ref Player jugador)
        {
            if (jugador.puntos > 21)
            {
                for (int i = 0; i < jugador.cartasEnMano; i++)
                {
                    if (jugador.mano[i].Puntos == 11)
                    {
                        jugador.mano[i].Puntos = 1;
                        jugador.puntos -= 10;
                        break;
                    }
                }
            }
        }

        private void MostrarMano(Player jugador)
        {
            Console.Write("Mano actual: ");
            for (int i = 0; i < jugador.cartasEnMano; i++)
            {
                MostrarSimboloCarta(jugador.mano[i]);
            }
            Console.WriteLine(" Puntos actuales: {0}", jugador.puntos);
        }

        private void MostrarSimboloCarta(PlayingCard carta)
        {
            switch (carta.Valor)
            {
                case 1: Console.Write("A{0} ", carta.Palo); break;
                case 11: Console.Write("J{0} ", carta.Palo); break;
                case 12: Console.Write("Q{0} ", carta.Palo); break;
                case 13: Console.Write("K{0} ", carta.Palo); break;
                default: Console.Write("{0}{1} ", carta.Valor, carta.Palo); break;
            }
        }

        private void CalcularGanador(Player jugador, Player crupier)
        {
            Console.WriteLine("\nResultado final:");
            Console.WriteLine($"{jugador.name} tiene {jugador.puntos} puntos con {jugador.cartasEnMano} cartas.");
            Console.WriteLine($"{crupier.name} tiene {crupier.puntos} puntos con {crupier.cartasEnMano} cartas.\n");

            bool jugadorCincoCartas = jugador.cartasEnMano == 5 && jugador.puntos <= 21;
            bool crupierCincoCartas = crupier.cartasEnMano == 5 && crupier.puntos <= 21;

            if (jugador.puntos > 21 && crupier.puntos > 21)
            {
                Console.WriteLine("¡Ambos se pasaron! Nadie gana.");
            }
            else if (jugador.puntos > 21)
            {
                Console.WriteLine($"¡{crupier.name} gana! {jugador.name} se pasó.");
            }
            else if (crupier.puntos > 21)
            {
                Console.WriteLine($"¡{jugador.name} gana! {crupier.name} se pasó.");
            }
            else if (jugadorCincoCartas && !crupierCincoCartas)
            {
                Console.WriteLine($"¡{jugador.name} gana con 5 cartas sin pasarse!");
            }
            else if (!jugadorCincoCartas && crupierCincoCartas)
            {
                Console.WriteLine($"¡{crupier.name} gana con 5 cartas sin pasarse!");
            }
            else if (jugador.puntos > crupier.puntos)
            {
                Console.WriteLine($"¡{jugador.name} gana con más puntos!");
            }
            else if (jugador.puntos < crupier.puntos)
            {
                Console.WriteLine($"¡{crupier.name} gana con más puntos!");
            }
            else // empate
            {
                if (jugadorCincoCartas && crupierCincoCartas)
                    Console.WriteLine("¡Empate! Ambos lograron el truco de 5 cartas.");
                else
                    Console.WriteLine("¡Empate por puntos!");
            }
        }


    }
}
