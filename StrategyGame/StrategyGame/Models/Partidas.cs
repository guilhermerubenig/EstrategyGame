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
    
    public partial class Partidas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partidas()
        {
            this.PartidasResultado = new HashSet<PartidasResultado>();
        }
    
        public int ID { get; set; }
        public int TorneioID { get; set; }
        public System.DateTime Horario { get; set; }
        public bool Juiz { get; set; }
        public int QuantidadePartidas { get; set; }
        public System.TimeSpan Duracao { get; set; }
        public bool Premiacao { get; set; }
        public bool Pago { get; set; }
    
        public virtual Torneios Torneios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartidasResultado> PartidasResultado { get; set; }
    }
}
