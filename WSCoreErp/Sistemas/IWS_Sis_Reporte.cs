using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Sistemas;



namespace WSCoreErp.Sistemas
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWS_Sis_Reporte" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWS_Sis_Reporte
    {
        [OperationContract]
        List<tb_sis_reporte_Info> Get_List_reporte();
      

        [OperationContract]
        Boolean GrabarDB(tb_sis_reporte_Info Info);

        [OperationContract]
        Boolean ModificarDB(tb_sis_reporte_Info Info);



        [OperationContract]
        Boolean AnularDB(tb_sis_reporte_Info Info);

    }
}
