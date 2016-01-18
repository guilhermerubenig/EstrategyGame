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
    
    public partial class Gamer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gamer()
        {
            this.GrupoGamer = new HashSet<GrupoGamer>();
            this.GamerGame = new HashSet<GamerGame>();
            this.TorneioGrupoGamer = new HashSet<TorneioGrupoGamer>();
        }
    
        public int ID { get; set; }
        public string Nome_GMR { get; set; }
        public string Sobrenome_GMR { get; set; }
        public string Apelido_GMR { get; set; }
        public System.DateTime DataCadastro_GMR { get; set; }
        public Nullable<System.DateTime> DataNascimento_GMR { get; set; }
        public bool Ativo_GMR { get; set; }
        public string Email_GMR { get; set; }
        public string Nacionalidade { get; set; }
        public string Sexo_GMR { get; set; }
        public string Youtube_GMR { get; set; }
        public string Twitter_GMR { get; set; }
        public string Twitch_GMR { get; set; }
        public string Facebook_GMR { get; set; }
        public string Fone_GMR { get; set; }
        public string Imagem_GMR { get; set; }
        public string Senha_GMR { get; set; }
        public Nullable<bool> Positividade { get; set; }
        public Nullable<bool> Negatividade { get; set; }
        public bool Juiz_GMR { get; set; }
        public string Mensagem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrupoGamer> GrupoGamer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GamerGame> GamerGame { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TorneioGrupoGamer> TorneioGrupoGamer { get; set; }
    }
}
