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
    
    public partial class tb_sucursal
    {
        public tb_sucursal()
        {
            this.tb_puntoVta = new HashSet<tb_puntoVta>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string cod_sucursal { get; set; }
        public string cod_establecimiento { get; set; }
        public string nom_sucursal { get; set; }
        public bool estado { get; set; }
    
        public virtual tb_empresa tb_empresa { get; set; }
        public virtual ICollection<tb_puntoVta> tb_puntoVta { get; set; }
    }
}
