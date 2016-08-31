using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.SeguridadAcceso;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class tb_seg_usuario_sesion_sesion_Bus
    {
        tb_seg_usuario_sesion_Data Odata = new tb_seg_usuario_sesion_Data();

        public List<tb_seg_usuario_sesion_Info> Get_List_Usuario_Sesion()
        {
            return Odata.Get_List_Usuario_Sesion();
        }

        public tb_seg_usuario_sesion_Info Get_Info_Registro(decimal  IdRegistro)
        {

            return Odata.Get_Info_Registro(IdRegistro);

        }

        public Boolean GrabarDB(tb_seg_usuario_sesion_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(tb_seg_usuario_sesion_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        

    }
}
