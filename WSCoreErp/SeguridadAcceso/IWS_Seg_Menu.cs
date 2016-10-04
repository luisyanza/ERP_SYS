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
        /// <summary>  Inicia seg_menu_Bus
        /// Retorna La Lista del Menu completa
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<seg_menu_Info> Get_List_Menu();
        
        [OperationContract]
        List<seg_menu_Info> Get_List_Menu_Usuario(string IdUsuario);

        [OperationContract]
        seg_menu_Info Get_Info_Menu(string IdMenu);

        [OperationContract]
        Boolean GrabarDBMenu(seg_menu_Info Info);

        [OperationContract]
        Boolean ModificarDBMenu(seg_menu_Info Info);

        [OperationContract]
        Boolean AnularDBMenu(seg_menu_Info Info);

        //seg_menu_x_seg_usuario_Bus

        [OperationContract]
        seg_menu_x_seg_usuario_Info Get_Info_Menu_Usuario(string IdMenu, string IdUsuario);

        [OperationContract]
        Boolean GrabarDBMenu_x_Usuario(seg_menu_x_seg_usuario_Info Info);

        // seg_perfil_x_seg_menu_Bus
        [OperationContract]
        seg_perfil_x_seg_menu_Info Get_Info_Pefil_x_Menu(string IdMenu, int IdPErfil);

        [OperationContract]
        Boolean GrabarDBPerfil_x_menu(seg_perfil_x_seg_menu_Info Info);



    }
}
