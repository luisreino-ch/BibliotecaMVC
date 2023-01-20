using Biblioteca.Filters;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{

    [ValidarSesion]
    public class AdminController : Controller
    {
        private static Persona oPesona;
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Index", "Login");

            oPesona = (Persona)Session["Usuario"];

            return View();
        }

        public ActionResult CerrarSesion()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Login");
        }

    }
}