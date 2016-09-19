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

        seg_menu_Bus oBus = new seg_menu_Bus();

        public List<seg_menu_Info> Get_List_Menu()
        {
            return oBus.Get_List_Menu();
        }

        public List<seg_menu_Info> Get_List_Menu_Usuario(string IdUsuario)
        {
            return oBus.Get_List_Menu(IdUsuario);
        }

        public seg_menu_Info Get_Info_Menu(string IdMenu)
        {
            return oBus.Get_Info_Menu(IdMenu);
        }

        public bool GrabarDB(seg_menu_Info Info)
        {
            return oBus.GrabarDB(Info);
        }

        public bool ModificarDB(seg_menu_Info Info)
        {
            return oBus.ModificarDB(Info);
        }

        public bool AnularDB(seg_menu_Info Info)
        {
            return oBus.AnularDB(Info);
        }
    }
}
