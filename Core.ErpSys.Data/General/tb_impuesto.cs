//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.ErpSys.Data.General
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_impuesto
    {
        public string IdImpuesto { get; set; }
        public string nom_Impuesto_tipo { get; set; }
        public string IdImpuesto_tipo { get; set; }
    
        public virtual tb_Impuesto_tipo tb_Impuesto_tipo { get; set; }
    }
}
