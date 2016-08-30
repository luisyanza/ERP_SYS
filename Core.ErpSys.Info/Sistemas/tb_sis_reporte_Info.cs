using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Sistemas
{
   public class tb_sis_reporte_Info
    {
        public string IdReporte { get; set; }
        public string nom_reporte { get; set; }


        public tb_sis_reporte_Info()
        {

        }

        public tb_sis_reporte_Info(string _IdReporte, string _nom_reporte)
        {
            IdReporte = _IdReporte;
            nom_reporte = _nom_reporte;

        }

    }
}
