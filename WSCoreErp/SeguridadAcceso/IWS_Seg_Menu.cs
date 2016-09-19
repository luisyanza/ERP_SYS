using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.SeguridadAcceso;

namespace WSCoreErp.SeguridadAcceso
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWS_Seg_Menu
    {
        [OperationContract]
        List<seg_menu_Info> Get_List_Menu();
        
        [OperationContract]
        List<seg_menu_Info> Get_List_Menu_Usuario(string IdUsuario);

        [OperationContract]
        seg_menu_Info Get_Info_Menu(string IdMenu);

        [OperationContract]
        Boolean GrabarDB(seg_menu_Info Info);

        [OperationContract]
        Boolean ModificarDB(seg_menu_Info Info);

        [OperationContract]
        Boolean AnularDB(seg_menu_Info Info);




    }
}
