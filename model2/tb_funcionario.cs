//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace model2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_funcionario
    {
        public int ID { get; set; }
        public Nullable<int> Inscricao { get; set; }
        public string Cargo { get; set; }
        public string Especializacao { get; set; }
        public string Registro { get; set; }
        public string Endereco { get; set; }
    
        public virtual tb_Usuario tb_Usuario { get; set; }
    }
}
