using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase4_Intro_a_POO.Models
{
    public class DirectorTecnicoAltaVM
    {
        public List<Jugador> Arqueros { get; set; }
        public List<Jugador> Delanteros { get; set; }
    }
}