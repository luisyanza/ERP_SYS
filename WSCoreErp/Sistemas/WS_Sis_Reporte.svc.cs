using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Sistemas;
using Core.ErpSys.Bus.Sistemas;



namespace WSCoreErp.Sistemas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WS_Sis_Reporte" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WS_Sis_Reporte.svc o WS_Sis_Reporte.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WS_Sis_Reporte : IWS_Sis_Reporte
    {

        tb_sis_reporte_Bus OBus = new tb_sis_reporte_Bus();

        public List<tb_sis_reporte_Info> Get_List_reporte()
        {
            return OBus.Get_List_Reporte();
        }

       

        public bool GrabarDB(tb_sis_reporte_Info Info)
        {
            return OBus.GrabarDB(Info);
        }




        public bool ModificarDB(tb_sis_reporte_Info Info)
        {
            return OBus.ModificarDB(Info);
        }

        public bool AnularDB(tb_sis_reporte_Info Info)
        {
            return OBus.AnularDB(Info);
        }
    }
}
