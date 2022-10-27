using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaExamenParcial1
{
    internal class Funciones
    {
        public static string GetJugadaMaquina()
        {
            Random rnd = new Random();
            int maquina = rnd.Next(1, 3);
            if (maquina == 1) return "PIEDRA";
            else if (maquina == 2) return "PAPEL";
            else return "TIJERAS";
        }
    }
}
