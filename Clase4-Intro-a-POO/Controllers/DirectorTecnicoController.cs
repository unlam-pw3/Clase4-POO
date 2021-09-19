using Clase4_Intro_a_POO.Models;
using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase4_Intro_a_POO.Controllers
{
    public class DirectorTecnicoController : Controller
    {

        private DirectorTecnicoAltaVM ObtenerDirectorTecnicoAltaVM()
        {
            List<Jugador> arqueros = JugadorServicio.ObtenerArqueros();
            List<Jugador> delanteros = JugadorServicio.ObtenerDelanteros();
            DirectorTecnicoAltaVM model = new DirectorTecnicoAltaVM();

            model.Arqueros = arqueros;
            model.Delanteros = delanteros;

            return model;
        }

        private DirectorTecnicoAltaVM ObtenerDirectoresTecnicos()
        {            
            List<DirectorTecnico> dts = DirectorTecnicoServicio.ObtenerTodos();
            DirectorTecnicoAltaVM model = new DirectorTecnicoAltaVM();

            model.DTs = dts;

            return model;
        }
        private DirectorTecnicoAltaVM Ganador1()
        {
            DirectorTecnico dtGanador = DirectorTecnicoServicio.ObtenerGanador();
            DirectorTecnicoAltaVM model = new DirectorTecnicoAltaVM();

            model.ganador = dtGanador;

            return model;
        }

        // GET: DirectorTecnico
        [HttpGet]
        public ActionResult Alta()
        {
            var model = ObtenerDirectorTecnicoAltaVM();
            return View(model);
        }

        [HttpPost]
        public ActionResult Alta(DirectorTecnico dt)
        {
            Int32.TryParse(Request["IdArquero"], out int idArquero);
            Int32.TryParse(Request["idDelantero1"], out int idDelantero1);
            Int32.TryParse(Request["idDelantero2"], out int idDelantero2);

            DirectorTecnicoServicio.Crear(dt, idArquero, idDelantero1, idDelantero2);

            var model = ObtenerDirectorTecnicoAltaVM();
            return View(model);
        }


        // GET: DirectoresTecnicos
        [HttpGet]
        public ActionResult Todos()
        {
            var model = ObtenerDirectoresTecnicos();
            return View(model);
        }

        // GET: Ganadores
        [HttpGet]
        public ActionResult Ganador()
        {
            var model = Ganador1();
            return View(model);
        }


    }
}