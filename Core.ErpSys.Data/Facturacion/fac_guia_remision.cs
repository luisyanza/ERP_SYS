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
    
    public partial class fac_guia_remision
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdPuntoVta { get; set; }
        public decimal IdGuiaRemision { get; set; }
        public string CodGuiaRemision { get; set; }
        public string num_CbteVta { get; set; }
        public string num_autorizacion { get; set; }
        public Nullable<System.DateTime> Fecha_Autorizacion { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdTransportista { get; set; }
        public System.DateTime gi_fecha { get; set; }
        public Nullable<decimal> gi_plazo { get; set; }
        public Nullable<System.DateTime> gi_fech_venc { get; set; }
        public string gi_Observacion { get; set; }
        public Nullable<double> gi_TotalKilos { get; set; }
        public Nullable<double> gi_TotalQuintales { get; set; }
        public bool estado { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<bool> Impreso { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime gi_FechaIniTraslado { get; set; }
        public System.DateTime gi_FechaFinTraslado { get; set; }
        public string placa { get; set; }
        public string ruta { get; set; }
        public string Direccion_Origen { get; set; }
        public string Direccion_Destino { get; set; }
    }
}
