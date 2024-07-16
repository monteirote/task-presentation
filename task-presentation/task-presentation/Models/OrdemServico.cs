using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using task_presentation.Database;

namespace task_presentation.Models {
    public class OrdemServico {
        
        public static List<OrdemServicoDTO> ListarOrdemServico() {
            using (var banco = new TASK_PRESENTATIONEntities()) {
                var listaOs = (from os in banco.ORDEM_SERVICO
                               join c in banco.CLIENTE on os.CD_CLIENTE equals c.CD_CLIENTE
                               where os.IC_CANCELAMENTO == null
                               select new OrdemServicoDTO() {
                                   CD_OS = os.CD_OS,
                                   DS_OS = os.DS_OS,
                                   NM_CLIENTE = c.NM_CLIENTE,
                                   DT_CRIACAO = os.DT_CRIACAO,
                                   DT_ENTREGA = os.DT_ENTREGA,
                                   DS_OBSERVACAO = os.DS_OBSERVACAO
                               }).ToList();

                return listaOs;
            }
        }
    }

    public class OrdemServicoDTO {
        public int CD_OS { get; set; }
        public int? DS_OS { get; set; }
        public string NM_CLIENTE { get; set; }
        public DateTime? DT_CRIACAO { get; set; }
        public DateTime? DT_ENTREGA { get; set; }
        public string DS_OBSERVACAO { get; set; }
    }
}