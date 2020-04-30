using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arquero : Jugador
    {
        const int PUNTAJE_PENAL_ATAJADO = 100;
        public int PenalesAtajados { get; set; }

        public override int CalcularPuntaje()
        {
            //(*)[Puntos de arquero] = [Cant de penales atajados] * 100
            //(*) Si el jugador fue expulsado se debe restar 50 puntos
            int puntaje = PenalesAtajados * 100;

            if (Expulsado)
            {
                puntaje -= Jugador.PUNTAJE_EXPULSADO;
            }

            return puntaje;
            //return PenalesAtajados * 100 - (Expulsado ? 50 : 0);
        }
    }
}
