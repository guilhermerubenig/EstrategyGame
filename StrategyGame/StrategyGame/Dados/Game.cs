//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StrategyGame.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.PlataformaGame = new HashSet<PlataformaGame>();
        }
    
        public int ID { get; set; }
        public string Nome_GAM { get; set; }
        public Nullable<System.DateTime> DataCadastro_GAM { get; set; }
        public Nullable<bool> Ativo_GAM { get; set; }
        public Nullable<int> Recomenda_GAM { get; set; }
        public string Imagem_GAM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlataformaGame> PlataformaGame { get; set; }
    }
}
