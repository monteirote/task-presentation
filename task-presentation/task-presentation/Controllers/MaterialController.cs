using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task_presentation.Models;
using static task_presentation.Models.Material;

namespace task_presentation.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Material
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CarregarListaFundo() {
            var comboMateriais = Material.BuscarFundos();
            var info = new PaginaInfo() { TituloPagina = "Fundo", ComboMateriais = comboMateriais };

            return View("ListaMateriais", info);
        }

        public ActionResult CarregarListaMoldura() {
            var comboMateriais = Material.BuscarMolduras();
            var info = new PaginaInfo() { TituloPagina = "Tipos de Moldura", ComboMateriais = comboMateriais };

            return View("ListaMateriais", info);
        }

        public ActionResult CarregarListaImpressao() {
            var comboMateriais = Material.BuscarImpressao();
            var info = new PaginaInfo() { TituloPagina = "Tipos de Impressão", ComboMateriais = comboMateriais };

            return View("ListaMateriais", info);
        }

        public ActionResult CarregarListaVidro() {
            var comboMateriais = Material.BuscarVidro();
            var info = new PaginaInfo() { TituloPagina = "Tipos de Vidro", ComboMateriais = comboMateriais };

            return View("ListaMateriais", info);
        }
    }
}