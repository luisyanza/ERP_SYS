using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.SeguridadAcceso;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class seg_menu_x_seg_usuario_Bus
    {
        seg_menu_x_seg_usuario_Data Odata = new seg_menu_x_seg_usuario_Data();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdMenu"></param>
        /// <param name="IdUsuario"></param>
        /// <returns></returns>
        public seg_menu_x_seg_usuario_Info Get_Info_Menu_Usuario(string IdMenu, string  IdUsuario)
        {
            return Odata.Get_Info_Menu_Usuario(IdMenu,IdUsuario);
        }

        public Boolean GrabarDB(seg_menu_x_seg_usuario_Info Info)
        {
            return Odata.GrabarDB(Info);
        }
    }
}
