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
    
    public partial class fac_orden_pedido
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdPedido { get; set; }
        public string CodPedido { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public System.DateTime cp_fecha { get; set; }
        public int cp_diasPlazo { get; set; }
        public System.DateTime cp_fechaVenc { get; set; }
        public string cp_observacion { get; set; }
        public string cp_tipopago { get; set; }
        public bool Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public Nullable<bool> Entregado { get; set; }
    }
}
