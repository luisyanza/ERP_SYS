using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class tb_seg_menu_x_seg_usuario_Data
    {
        public tb_seg_menu_x_seg_usuario_Info Get_Info_Menu_Usuario(string IdMenu, string IdUsuario)
        {
            tb_seg_menu_x_seg_usuario_Info Info = new tb_seg_menu_x_seg_usuario_Info();
            try
            {
                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                var selectq = from q in OBase.seg_menu_x_seg_usuario
                              where q.IdMenu == IdMenu && q.IdUsuario == IdUsuario
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdMenu = item.IdMenu;
                    Info.IdUsuario = item.IdUsuario;
                    Info.observacion = item.observacion;
                }
            }
            catch (Exception)
            {

                return new tb_seg_menu_x_seg_usuario_Info();
            }


            return Info;

        }

        public Boolean GrabarDB(tb_seg_menu_x_seg_usuario_Info Info)
        {
            try
            {
                using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                {
                    var addressG = new seg_menu_x_seg_usuario();
                    addressG.IdMenu = Info.IdMenu;
                    addressG.IdUsuario = Info.IdUsuario;
                    addressG.observacion = Info.observacion;
                    context.seg_menu_x_seg_usuario.Add(addressG);
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
