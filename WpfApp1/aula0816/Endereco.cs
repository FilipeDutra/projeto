//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aula0816
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        public int Id { get; set; }
        public string Logadouro { get; set; }
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
