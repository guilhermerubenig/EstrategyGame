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
    
    public partial class PartidasResultado
    {
        public int ID { get; set; }
        public int PartidasID { get; set; }
        public int Gamer { get; set; }
        public decimal Pontos { get; set; }
        public string Imagem { get; set; }
        public string Twitch { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
    
        public virtual Partidas Partidas { get; set; }
    }
}
