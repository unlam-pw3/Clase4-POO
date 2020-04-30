using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Delantero : Jugador
    {
        const int PUNTAJE_PENAL_CONVERTIDO = 75;
        public int PenalesConvertidos { get; set; }

        public override int CalcularPuntaje()
        {
            //(*)[Puntos de delantero] = [Cant de penales convertidos] * 75
            //(*) Si el jugador fue expulsado se debe restar 50 puntos

            int puntaje = PenalesConvertidos * PUNTAJE_PENAL_CONVERTIDO;

            if (Expulsado)
            {
                puntaje -= Jugador.PUNTAJE_EXPULSADO;
            }

            return puntaje;
        }
    }
}
