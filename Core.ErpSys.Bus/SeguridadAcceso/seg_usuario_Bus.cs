using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;
using Core.ErpSys.Data.SeguridadAcceso ;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class seg_usuario_Bus
    {
        seg_usuario_Data Odata = new seg_usuario_Data();

        public List<seg_usuario_Info> Get_List_Usuario()
        {
            return Odata.Get_List_Usuario();
        }

        public seg_usuario_Info Get_Info_Usuario(string IdUsuario)
        {

            return Odata.Get_Info_Usuario(IdUsuario);

        }

        public Boolean GrabarDB(seg_usuario_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(seg_usuario_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        public Boolean AnularDB(seg_usuario_Info Info)
        {
            return Odata.AnularDB(Info);

        }
    }
}
