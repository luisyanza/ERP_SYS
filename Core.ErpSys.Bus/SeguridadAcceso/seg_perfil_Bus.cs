using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;
using Core.ErpSys.Data.SeguridadAcceso;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class seg_perfil_Bus
    {
        
        seg_perfil_Data Odata = new seg_perfil_Data();

        public List<seg_perfil_Info> Get_List_Perfil()
        {
            return Odata.Get_List_Perfil();
        }

        public seg_perfil_Info Get_Info_Perfil(int IdPErfil)
        {

            return Odata.Get_Info_Perfil(IdPErfil );

        }

        public Boolean GrabarDB(seg_perfil_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(seg_perfil_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        public Boolean AnularDB(seg_perfil_Info Info)
        {
            return Odata.AnularDB(Info);

        }
    }
}
