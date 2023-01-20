using Biblioteca.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    [ValidarSesion]
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Usuarios()
        {
            return View();
        }

        public ActionResult Lectores()
        {
            return View();
        }


    }
}