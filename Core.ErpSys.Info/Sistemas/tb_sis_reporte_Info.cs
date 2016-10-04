using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Sistemas
{
    /// <summary>
    /// clase de reporteria
    /// </summary>
    public class tb_sis_reporte_Info
    {
        public string IdReporte;
        public string Nom_reporte;
        public string Nom_Corto_reporte;
        public string IdModulo;
        public string VistaRpt;
        public string Formulario;
        public string Class_NomReporte;
        public string nom_Asembly;
        public int? Orden;
        public string Observacion;
        public byte[] imagen;
        public int? VersionActual;
        public string Tipo_Balance;
        public string SQuery;
        public string Class_Info;
        public string Class_Bus;
        public string Class_Data;
        public int? IdGrupo_Reporte;
        public bool? se_Muestra_Admin_Reporte;
        public bool Estado;
        public string Store_proce_rpt;
        public byte[] Disenio_reporte;


        public tb_sis_reporte_Info()
        {

        }
        

        public tb_sis_reporte_Info(string _IdReporte, string _Nom_reporte, string _Nom_Corto_reporte, string _IdModulo, string _VistaRpt, string p6, string p7, string p8, int? nullable1, string p9, byte[] p10, int? nullable2, string p11, string p12, string p13, string p14, string p15, int? nullable3, bool? nullable4, bool p16, string p17, byte[] p18)
        {
            // TODO: Complete member initialization
            this.IdReporte = _IdReporte;
            this.Nom_reporte = _Nom_reporte;
            this.Nom_Corto_reporte = _Nom_Corto_reporte;
            this.IdModulo = _IdModulo;
            this.VistaRpt = _VistaRpt;
            this.Formulario = p6;
            this.Class_NomReporte = p7;
            this.nom_Asembly = p8;
            this.Orden = nullable1;
            this.Observacion = p9;
            this.imagen = p10;
            this.VersionActual = nullable2;
            this.Tipo_Balance = p11;
            this.SQuery = p12;
            this.Class_Info = p13;
            this.Class_Bus = p14;
            this.Class_Data = p15;
            this.IdGrupo_Reporte = nullable3;
            this.se_Muestra_Admin_Reporte = nullable4;
            this.Estado = p16;
            this.Store_proce_rpt = p17;
            this.Disenio_reporte = p18;
        }


    }
}
