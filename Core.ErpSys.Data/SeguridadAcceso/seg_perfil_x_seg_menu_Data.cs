using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class seg_perfil_x_seg_menu_Data
    {


        public seg_perfil_x_seg_menu_Info Get_Info_Pefil_x_Menu(string IdMenu, int IdPerfil)
        {
            try
            {
                seg_perfil_x_seg_menu_Info Info = new seg_perfil_x_seg_menu_Info();

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_perfil_x_seg_menu
                              where q.IdMenu == IdMenu && q.IdPerfil == IdPerfil
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdMenu = item.IdMenu;
                    Info.IdPerfil = item.IdPerfil;
                    Info.observacion = item.observacion;
                }
                return Info;
            }
            catch (Exception)
            {

                return new seg_perfil_x_seg_menu_Info();
            }



        }

        public Boolean GrabarDB(seg_perfil_x_seg_menu_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var addressG = new seg_perfil_x_seg_menu();
                    addressG.IdMenu = Info.IdMenu;
                    addressG.IdPerfil = Info.IdPerfil;
                    addressG.observacion = Info.observacion;
                    context.seg_perfil_x_seg_menu.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;
        }

    }
}
