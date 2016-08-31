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
        public string IdReporte { get; set; }
        public string cod_reporte { get; set; }
        public string nom_reporte { get; set; }
        public bool estado { get; set; }

        public tb_sis_reporte_Info()
        {

        }

        public tb_sis_reporte_Info(string _IdReporte, string _nom_reporte, string _cod_reporte, bool _estado)
        {
            IdReporte = _IdReporte;
            cod_reporte = _cod_reporte;
            nom_reporte = _nom_reporte;
            estado = _estado;

        }

    }
}
