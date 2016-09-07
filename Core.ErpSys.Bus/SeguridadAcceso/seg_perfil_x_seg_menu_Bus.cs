using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.SeguridadAcceso;
using Core.ErpSys.Info.SeguridadAcceso;


namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class seg_perfil_x_seg_menu_Bus
    {
        seg_perfil_x_seg_menu_Data Odata = new seg_perfil_x_seg_menu_Data();

        
        public seg_perfil_x_seg_menu_Info Get_Info_Pefil_x_Menustring(string IdMenu, int IdPErfil)
        {

            return Odata.Get_Info_Pefil_x_Menu(IdMenu,IdPErfil);

        }

        public Boolean GrabarDB(seg_perfil_x_seg_menu_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

       
       
    }
}
