using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Sistemas;
using Core.ErpSys.Data.Sistemas;


namespace Core.ErpSys.Bus.Sistemas
{
   public class tb_sis_reporte_Bus
    {

       tb_sis_reporte_Data Odata = new tb_sis_reporte_Data();

        public List<tb_sis_reporte_Info> Get_List_Reporte()
        {
            return Odata.Get_List_Reporte();
        }

       
        public tb_sis_reporte_Info Get_Info_Reporte(string IdReporte)
        {

            return Odata.Get_Info_Reporte(IdReporte);

        }

        public Boolean GrabarDB(tb_sis_reporte_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(tb_sis_reporte_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        public Boolean AnularDB(tb_sis_reporte_Info Info)
        {
            return Odata.AnularDB(Info);

        }

    }
}
