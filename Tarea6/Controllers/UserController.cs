using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea6.Models;

namespace Tarea6.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View(new User());
        }

        public ActionResult Formulario()
        {
            return View(new User());
        }

        public ActionResult Perfil(User user)
        {
            return View(user);
        }

        [HttpPost]
        public ActionResult Formulario(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            return View("Perfil", user);
        }
    }
}