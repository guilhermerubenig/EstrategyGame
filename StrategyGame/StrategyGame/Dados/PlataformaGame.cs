//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StrategyGame.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlataformaGame
    {
        public PlataformaGame()
        {
            this.GamerGame = new HashSet<GamerGame>();
            this.Grupo = new HashSet<Grupo>();
        }
    
        public int ID { get; set; }
        public int PlataformaID { get; set; }
        public int GameID { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual ICollection<GamerGame> GamerGame { get; set; }
        public virtual ICollection<Grupo> Grupo { get; set; }
        public virtual Plataforma Plataforma { get; set; }
    }
}
