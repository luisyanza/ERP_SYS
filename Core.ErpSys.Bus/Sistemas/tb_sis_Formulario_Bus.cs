using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Sistemas;
using Core.ErpSys.Info.Sistemas;
using Core.ErpSys.Info.General;


namespace Core.ErpSys.Bus.Sistemas
{
    public class tb_sis_Formulario_Bus
    {
        tb_sis_Formulario_Data Odata = new tb_sis_Formulario_Data();

        public List<tb_sis_Formulario_Info> Get_List_Formulario()
        {
            return Odata.Get_List_Formulario();
        }
        
        public tb_sis_Formulario_Info Get_Info_Formulario(string IdFormulario)
        {

            return Odata.Get_Info_Formulario(IdFormulario);

        }

        public Boolean GrabarDB(tb_sis_Formulario_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(tb_sis_Formulario_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        public Boolean AnularDB(tb_sis_Formulario_Info Info)
        {
            return Odata.AnularDB(Info);

        }
    }
}
