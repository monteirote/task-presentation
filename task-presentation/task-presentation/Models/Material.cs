using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using task_presentation.Database;

namespace task_presentation.Models {
    public class Material {

        public class MaterialCombo {
            public int ID { get; set; }
            public string DS_NOME { get; set; }
        }
        public class PaginaInfo {
            public string TituloPagina { get; set; }
            public List<MaterialCombo> ComboMateriais { get; set; }
        }

        public static List<MaterialCombo> BuscarFundos() {
            using (var banco = new TASK_PRESENTATIONEntities()) {

                var list = (from f in banco.TIPO_FUNDO
                            select new MaterialCombo() { 
                                ID = f.CD_FUNDO,
                                DS_NOME = f.DS_FUNDO
                            }).ToList();

                return list;
            }
        }
        public static List<MaterialCombo> BuscarMolduras() {
            using (var banco = new TASK_PRESENTATIONEntities()) {

                var list = (from f in banco.TIPO_MOLDURA
                            select new MaterialCombo() {
                                ID = f.CD_MOLDURA,
                                DS_NOME = f.DS_MOLDURA
                            }).ToList();

                return list;
            }
        }
        public static List<MaterialCombo> BuscarImpressao() {
            using (var banco = new TASK_PRESENTATIONEntities()) {

                var list = (from f in banco.TIPO_IMPRESSAO
                            select new MaterialCombo() {
                                ID = f.CD_IMPRESSAO,
                                DS_NOME = f.DS_IMPRESSAO
                            }).ToList();

                return list;
            }
        }
        public static List<MaterialCombo> BuscarVidro() {
            using (var banco = new TASK_PRESENTATIONEntities()) {

                var list = (from f in banco.TIPO_VIDRO
                            select new MaterialCombo() {
                                ID = f.CD_VIDRO,
                                DS_NOME = f.DS_VIDRO
                            }).ToList();

                return list;
            }
        }

        public static bool AdicionarMaterial(string TipoMaterial, string NomeMaterial) {
            try {
                using (var banco = new TASK_PRESENTATIONEntities()) {
                    switch (TipoMaterial) {
                        case "Fundo":
                            banco.TIPO_FUNDO.Add(new TIPO_FUNDO() { DS_FUNDO = NomeMaterial });
                            banco.SaveChanges();
                            return true;
                        case "Impressao":
                            banco.TIPO_IMPRESSAO.Add(new TIPO_IMPRESSAO() { DS_IMPRESSAO = NomeMaterial });
                            banco.SaveChanges();
                            return true;
                        case "Moldura":
                            banco.TIPO_MOLDURA.Add(new TIPO_MOLDURA() { DS_MOLDURA = NomeMaterial });
                            banco.SaveChanges();
                            return true;
                        case "Vidro":
                            banco.TIPO_VIDRO.Add(new TIPO_VIDRO() { DS_VIDRO = NomeMaterial });
                            banco.SaveChanges();
                            return true;
                    }
                }
                return false;
            } catch {
                return false;
            }
            
        }
        public static bool EditarMaterial(int id, string TipoMaterial, string NovoNomeMaterial) {
            using (var banco = new TASK_PRESENTATIONEntities()) {
                
            }
        }
    }
}