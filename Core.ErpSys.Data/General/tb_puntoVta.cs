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
    
    public partial class tb_puntoVta
    {
        public int IdEmpresa { get; set; }
        public int IdPuntoVta { get; set; }
        public int IdSucursal { get; set; }
        public string cod_puntoVta { get; set; }
        public string nom_puntoVta { get; set; }
        public bool estado { get; set; }
    
        public virtual tb_sucursal tb_sucursal { get; set; }
    }
}
