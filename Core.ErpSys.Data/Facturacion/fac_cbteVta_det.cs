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
    
    public partial class fac_cbteVta_det
    {
        public int IdEmpresa { get; set; }
        public string IdCbteVtaTipo { get; set; }
        public decimal IdCbteVta { get; set; }
        public int secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string observacion_det { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double por_descuento { get; set; }
        public double valor_descuento { get; set; }
        public double precio_final { get; set; }
        public double subtotal { get; set; }
        public double valor_impuesto_iva { get; set; }
        public double por_impuesto_iva { get; set; }
        public string IdImpuesto_Iva { get; set; }
        public double total { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string IdImpuesto_Ice { get; set; }
        public Nullable<double> valor_impuesto_ice { get; set; }
        public Nullable<double> por_impuesto_ice { get; set; }
    }
}
