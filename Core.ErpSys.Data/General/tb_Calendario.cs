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
    
    public partial class tb_Calendario
    {
        public int IdCalendario { get; set; }
        public System.DateTime fecha { get; set; }
        public string Nom_Fecha { get; set; }
        public string Nom_CortoFecha { get; set; }
        public Nullable<int> dia_x_semana { get; set; }
        public Nullable<int> dia_x_mes { get; set; }
        public string Inicial_del_Dia { get; set; }
        public string NombreDia { get; set; }
        public Nullable<int> Mes_x_anio { get; set; }
        public string NombreMes { get; set; }
        public Nullable<int> IdMes { get; set; }
        public string NombreCortoMes { get; set; }
        public Nullable<int> AnioFiscal { get; set; }
        public Nullable<int> Semana_x_anio { get; set; }
        public string Nom_Semana { get; set; }
        public Nullable<int> IdSemana { get; set; }
        public Nullable<int> Trimestre_x_Anio { get; set; }
        public string Nom_Trimestre { get; set; }
        public Nullable<int> IdTrimestre { get; set; }
        public string IdPeriodo { get; set; }
        public string EsFeriado { get; set; }
        public string Descripcion { get; set; }
    }
}