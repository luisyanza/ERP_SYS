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
    
    public partial class tb_empresa
    {
        public tb_empresa()
        {
            this.tb_sucursal = new HashSet<tb_sucursal>();
        }
    
        public int IdEmpresa { get; set; }
        public string cod_empresa { get; set; }
        public string nom_empresa { get; set; }
        public string ruc_empresa { get; set; }
        public bool estado { get; set; }
    
        public virtual ICollection<tb_sucursal> tb_sucursal { get; set; }
    }
}