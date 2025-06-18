using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioCasino
{
    public class Veintiuno
    {
        public class PlayingCard
        {
            public string Palo;
            public int Valor;
            public int Puntos;

            public PlayingCard(int s, int v)
            {
                Valor = v; // numero de cartes de 1-13
                switch (s) // num a simbolo
                {
                    case 1: Palo = "♣"; break;
                    case 2: Palo = "♦"; break; //simbolos de cartas (palo)
                    case 3: Palo = "♥"; break;
                    case 4: Palo = "♠"; break;
                    default: Palo = ""; break;
                }
                Puntos = (Valor > 10) ? 10 : (Valor == 1 ? 11 : Valor); // puntos 
            }
        }

        public class Player
        {
            public PlayingCard[] mano = new PlayingCard[5];
            public int cartasEnMano = 0;
            public int puntos = 0;
            public string name;
        }

        public PlayingCard[] baraja;
        public int puntero = 0;

        public Veintiuno()
        {
            baraja = GenerarBaraja();
            MezclarBaraja(ref baraja); // mescla y altera el arreglo original
        }

        public void Jugar()
        {
            string jugarOtraVez;
            string nombreJugador = "";

            Console.WriteLine("╔═════════════════════════════════════╗");
            Console.WriteLine("║        BIENVENIDO AL VEINTIUNO      ║");
            Console.WriteLine("╚═════════════════════════════════════╝\n");

            do
            {
                puntero = 0;
                baraja = GenerarBaraja(); // genera y mescla la baraja
                MezclarBaraja(ref baraja);

                Player jugador = new Player();
                Console.Write("Por favor, introduce tu nombre: ");
                jugador.name = Console.ReadLine();
                nombreJugador = jugador.name;

                Player crupier = new Player();
                Console.Write("Por favor, introduce el nombre del crupier: ");
                crupier.name = Console.ReadLine();

                RobarCarta(ref jugador); // roba 2 cartas 
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

                    while (crupierVivo && crupier.puntos < 15 && crupier.cartasEnMano < 5)
                    {
                        Console.WriteLine("El crupier pide una carta...");
                        Console.ReadLine();
                        RobarCarta(ref crupier);
                        VerificarAses(ref crupier);
                        MostrarMano(crupier);
                        crupierVivo = VerificarPuntos(crupier);
                    }

                    if (crupier.puntos >= 15 && crupier.puntos <= 21)
                    {
                        Console.WriteLine("El crupier se planta.");
                    }
                }

                CalcularGanador(jugador, crupier);

                Console.Write("¿Quieres jugar de nuevo? (Y/N): ");
                jugarOtraVez = Console.ReadLine().ToUpper();

            } while (jugarOtraVez == "Y");

            Console.WriteLine($"\n╔════════════════════════════════════════╗");
            Console.WriteLine($" Gracias por jugar,{nombreJugador,-15} ");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }


        public PlayingCard[] GenerarBaraja()
        {
            PlayingCard[] baraja = new PlayingCard[52]; //crea arreglo de52 c.
            int contador = 0;
            for (int palo = 1; palo < 5; palo++)  // simbolo de cartas
            {
                for (int valor = 1; valor < 14; valor++)  //1 as 13 rey
                {
                    baraja[contador++] = new PlayingCard(palo, valor); //crea una carta con p,v y almacena luego incrementa contador
                }
            }
            return baraja;
        }

        public void MezclarBaraja(ref PlayingCard[] baraja)  //cartas 52 almacena en el arreglo baraja
        {
            Random rnd = new Random();
            for (int i = 0; i < baraja.Length; i++) // 0-51
            {
                int r = rnd.Next(baraja.Length); // posicion aleatoria r
                var temp = baraja[i];
                baraja[i] = baraja[r];  // cambia la carta actual i 
                baraja[r] = temp;       // con la carta aleatoria r
            }
        }

        public void RobarCarta(ref Player jugador)
        {
            PlayingCard siguienteCarta = baraja[puntero++];
            if (jugador.cartasEnMano < 5) // max 5 cartas
            {
                jugador.mano[jugador.cartasEnMano++] = siguienteCarta;
                jugador.puntos += siguienteCarta.Puntos; // suma de carta + suma en mano
            }
        }

        public bool VerificarPuntos(Player jugador)
        {
            if (jugador.puntos > 21)
            {
                Console.WriteLine("¡Te pasaste!");
                return false;
            }
            return true;
        }

        public void VerificarAses(ref Player jugador)
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

        public void MostrarMano(Player jugador)
        {
            Console.WriteLine($"\n╔══════════════════════════════════╗");
            Console.WriteLine($" Jugador: {jugador.name,-15}");
            Console.Write(" Mano: ");
            for (int i = 0; i < jugador.cartasEnMano; i++)
            {
                MostrarSimboloCarta(jugador.mano[i]);
            }
            int espacios = 28 - (jugador.cartasEnMano * 4);
            Console.Write(new string(' ', espacios));
            Console.WriteLine("");
            Console.WriteLine($" Puntos: {jugador.puntos,-24}");
            Console.WriteLine("╚══════════════════════════════════╝\n");
        }

        public void MostrarSimboloCarta(PlayingCard carta)
        {
            switch (carta.Valor)
            {
                case 1: Console.Write($"A{carta.Palo} "); break;
                case 11: Console.Write($"J{carta.Palo} "); break;
                case 12: Console.Write($"Q{carta.Palo} "); break;
                case 13: Console.Write($"K{carta.Palo} "); break;
                default: Console.Write($"{carta.Valor}{carta.Palo} "); break;
            }
        }

        public void CalcularGanador(Player jugador, Player crupier)
        {
            Console.WriteLine("═════════════════════════════════════");
            Console.WriteLine("       RESULTADO FINAL DE LA RONDA");
            Console.WriteLine("═════════════════════════════════════");
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
            else
            {
                if (jugadorCincoCartas && crupierCincoCartas)
                    Console.WriteLine("¡Empate! Ambos lograron el truco de 5 cartas.");
                else
                    Console.WriteLine("¡Empate por puntos!");
            }

            Console.WriteLine("═════════════════════════════════════\n");
        }

    }
}
