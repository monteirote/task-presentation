using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task_presentation.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Models.LoginModel user) {

            var senhaValida = user.VerificarSenha();

            if (senhaValida) return RedirectToAction("Index", "Home");

            ViewBag.Erro = "Login inválido";

            return View("Index");
        }
    }
}