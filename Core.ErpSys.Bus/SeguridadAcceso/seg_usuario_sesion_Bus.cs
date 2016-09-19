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
        seg_usuario_sesion_Data Odata = new seg_usuario_sesion_Data();

        public List<seg_usuario_sesion_Info> Get_List_Usuario_Sesion()
        {
            return Odata.Get_List_Usuario_Sesion();
        }

        public seg_usuario_sesion_Info Get_Info_Usuario_Sesion(decimal IdRegistro)
        {

            return Odata.Get_Info_Usuario_Sesion(IdRegistro);

        }

        public Boolean GrabarDB(seg_usuario_sesion_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(seg_usuario_sesion_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        

    }
}
