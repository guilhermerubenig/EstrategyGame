//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StrategyGame.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Torneios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Torneios()
        {
            this.Partidas = new HashSet<Partidas>();
            this.TorneioGrupoGamer = new HashSet<TorneioGrupoGamer>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataInicio { get; set; }
        public System.DateTime DataFim { get; set; }
        public string Local { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<int> GamerID { get; set; }
        public Nullable<bool> Pago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partidas> Partidas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TorneioGrupoGamer> TorneioGrupoGamer { get; set; }
    }
}
