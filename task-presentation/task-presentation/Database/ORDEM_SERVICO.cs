//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace task_presentation.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDEM_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDEM_SERVICO()
        {
            this.QUADRO_OS = new HashSet<QUADRO_OS>();
        }
    
        public int CD_OS { get; set; }
        public Nullable<int> DS_OS { get; set; }
        public Nullable<int> CD_CLIENTE { get; set; }
        public Nullable<System.DateTime> DT_CRIACAO { get; set; }
        public Nullable<System.DateTime> DT_ENTREGA { get; set; }
        public Nullable<int> IC_CANCELAMENTO { get; set; }
        public string DS_OBSERVACAO { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUADRO_OS> QUADRO_OS { get; set; }
    }
}