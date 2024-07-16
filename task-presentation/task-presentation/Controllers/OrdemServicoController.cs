using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task_presentation.Models;

namespace task_presentation.Controllers
{
    public class OrdemServicoController : Controller
    {
        // GET: OrdemServico
        public ActionResult Index()
        {
            ViewBag.ListaOS = OrdemServico.ListarOrdemServico();
            
            return View();
        }

        public ActionResult AdicionarNovaOrdemServico() {
            return View("NovaOrdemServico");
        }
    }
}