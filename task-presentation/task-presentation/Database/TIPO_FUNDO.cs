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
    
    public partial class TIPO_FUNDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_FUNDO()
        {
            this.QUADRO_OS = new HashSet<QUADRO_OS>();
        }
    
        public int CD_FUNDO { get; set; }
        public string DS_FUNDO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUADRO_OS> QUADRO_OS { get; set; }
    }
}
