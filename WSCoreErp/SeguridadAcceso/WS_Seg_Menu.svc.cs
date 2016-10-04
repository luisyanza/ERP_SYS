using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.SeguridadAcceso;
using Core.ErpSys.Bus.SeguridadAcceso;

namespace WSCoreErp.SeguridadAcceso
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IWS_Seg_Menu
    {

        seg_menu_Bus oBusMenu = new seg_menu_Bus();

        public List<seg_menu_Info> Get_List_Menu()
        {
            return oBusMenu.Get_List_Menu();
        }

        public List<seg_menu_Info> Get_List_Menu_Usuario(string IdUsuario)
        {
            return oBusMenu.Get_List_Menu(IdUsuario);
        }

        public seg_menu_Info Get_Info_Menu(string IdMenu)
        {
            return oBusMenu.Get_Info_Menu(IdMenu);
        }

        public bool GrabarDBMenu(seg_menu_Info Info)
        {
            return oBusMenu.GrabarDB(Info);
        }

        public bool ModificarDBMenu(seg_menu_Info Info)
        {
            return oBusMenu.ModificarDB(Info);
        }

        public bool AnularDBMenu(seg_menu_Info Info)
        {
            return oBusMenu.AnularDB(Info);
        }

        seg_menu_x_seg_usuario_Bus oBusMenuUsuario = new seg_menu_x_seg_usuario_Bus();

        public seg_menu_x_seg_usuario_Info Get_Info_Menu_Usuario(string IdMenu, string IdUsuario)
        {

            return oBusMenuUsuario.Get_Info_Menu_Usuario(IdMenu, IdUsuario);

        }

        public Boolean GrabarDBMenu_x_Usuario(seg_menu_x_seg_usuario_Info Info)
        {
            return oBusMenuUsuario.GrabarDB(Info);

        }

        seg_perfil_x_seg_menu_Bus OBusPerfilMenu = new seg_perfil_x_seg_menu_Bus();


        public seg_perfil_x_seg_menu_Info Get_Info_Pefil_x_Menu(string IdMenu, int IdPErfil)
        {

            return OBusPerfilMenu.Get_Info_Pefil_x_Menu(IdMenu, IdPErfil);

        }

        public Boolean GrabarDBPerfil_x_menu(seg_perfil_x_seg_menu_Info Info)
        {
            return OBusPerfilMenu.GrabarDB(Info);

        }


    }
}
