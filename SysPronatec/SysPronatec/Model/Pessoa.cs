//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysPronatec.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public long IDPessoa { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public System.DateTime DataNas { get; set; }
        public string NomedaMae { get; set; }
        public string Cor { get; set; }
        public short EndereçoIDEndereco { get; set; }
    
        public virtual Candidato Candidato { get; set; }
        public virtual Endereço Endereço { get; set; }
    }
}
