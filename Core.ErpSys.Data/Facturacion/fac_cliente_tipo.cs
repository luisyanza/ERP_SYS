//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.ErpSys.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class fac_cliente_tipo
    {
        public int IdEmpresa { get; set; }
        public int Idtipo_cliente { get; set; }
        public string nom_tip_cliente { get; set; }
        public string IdCtaCble_CXC_Con { get; set; }
        public string IdCtaCble_CXC_Cred { get; set; }
        public string IdCtaCble_CXC_Anticipo { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public bool estado { get; set; }
    }
}
