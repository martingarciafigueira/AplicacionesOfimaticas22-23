using PlantillaExamenParcial1;

//Declaramos las variables
string opcion, opcionOrdenador;
string resultadoFinal;
int Jugador = 0;
int Computador = 0;
bool continuaBucle = true;

do
{
    opcionOrdenador = Funciones.GetJugadaMaquina();

    /* CONFIGURA AQUÍ LA INTERFAZ GRÁFICA - INICIO */

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("JUEGO PIEDRA, PAPEL, TIJERAS");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("¡Juegas contra el ordenador!");
    Console.WriteLine("Tienes las siguientes opciones:");
    Console.WriteLine("- PIEDRA");
    Console.WriteLine("- PAPEL");
    Console.WriteLine("- TIJERAS");
    Console.WriteLine("El juego se ejecuta hasta que metas la palabra 'STOP'");
    Console.WriteLine();
    Console.Write("Elige tu jugada: ");

    opcion = Console.ReadLine();

    /* CONFIGURA AQUÍ LA INTERFAZ GRÁFICA - FIN */

    /* CONFIGURA AQUÍ EL PROGRAMA - INICIO */

    if (opcion == "PIEDRA" || opcion == "PAPEL" || opcion == "TIJERAS")
    {
        Console.WriteLine("El ordenador sacó: " + opcionOrdenador);
        
        if (opcion == opcionOrdenador)
        {
            Console.WriteLine("EMPATE");
        }
        else if(opcion == "PIEDRA")
        {
            if (opcionOrdenador == "TIJERAS")
            {
                Console.WriteLine("JUGADOR GANADOR");
                Console.Beep(1000,1000);
            }
            else
            {
                Console.WriteLine("ORDENADOR GANADOR");

            }
        }
        else if (opcion == "PAPEL")
        {
            if (opcionOrdenador == "PIEDRA")
            {
                Console.WriteLine("JUGADOR GANADOR");
            }
            else
            {
                Console.WriteLine("ORDENADOR GANADOR");

            }
        }
        else if (opcion == "TIJERAS")
        {
            if (opcionOrdenador == "PAPEL")
            {
                Console.WriteLine("JUGADOR GANADOR");
            }
            else
            {
                Console.WriteLine("ORDENADOR GANADOR");
            }
        }
    }
    else if (opcion != "STOP")
    {
        Console.WriteLine("Vuelve a probar");
    }

    /* CONFIGURA AQUÍ EL PROGRAMA - FIN */

    if (opcion == "STOP")
    {
        Console.WriteLine("FIN DEL PROGRAMA");
        continuaBucle = false;
    }
    Console.ReadLine();
    Console.Clear();

} while (continuaBucle);
