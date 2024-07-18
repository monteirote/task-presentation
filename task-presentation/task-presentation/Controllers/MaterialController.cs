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

        public ActionResult CarregarPagina(string material) {
            return View("PaginaMaterial", new PaginaInfo { TituloPagina = material });
        }

    

        [HttpPost]
        public void AdicionarMaterial(string TipoMaterial, string NomeMaterial) {
            Material.AdicionarMaterial(TipoMaterial, NomeMaterial);
        }

        public ActionResult CarregarListaItens(string tipoMaterial) {
            var itens = new List<MaterialCombo>();

            switch (tipoMaterial) {
                case "Fundo": itens = Material.BuscarFundos(); break;
                case "Moldura": itens = Material.BuscarMolduras(); break;
                case "Impressao": itens = Material.BuscarImpressao(); break;
                case "Vidro": itens = Material.BuscarVidro(); break;
            }

            return PartialView("ListaMateriais", new PaginaInfo() { TituloPagina = tipoMaterial, ComboMateriais = itens });
        }

        [HttpPost]
        public void EditarMaterial(string tipoMaterial, int id, string novoNome) {
            Material.ed
        }
    }
}