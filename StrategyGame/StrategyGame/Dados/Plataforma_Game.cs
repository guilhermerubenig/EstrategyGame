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
    
    public partial class Plataforma_Game
    {
        public System.Guid id { get; set; }
        public System.Guid PlataformaID { get; set; }
        public System.Guid GameID { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual Plataforma Plataforma { get; set; }
    }
}
