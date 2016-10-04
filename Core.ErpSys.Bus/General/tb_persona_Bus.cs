using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.General;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Bus.General
{
    public class tb_persona_Bus
    {

        tb_persona_Data oData = new tb_persona_Data();

        public List<tb_persona_Info> Get_List_Personas()
        {

            try
            {
                return oData.Get_List_Personas();
            }
            catch (Exception)
            {
                return new List<tb_persona_Info>();

            }

        }


        public tb_persona_Info Get_Info_Persona(string NumDocumento)
        {

            try
            {
                return oData.Get_Info_Persona(NumDocumento);
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
        }
        public tb_persona_Info Get_Info_Persona(tb_persona_Info Info)
        {

            try
            {
                return oData.Get_Info_Persona(Info);
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
        }

        public Boolean GrabarDB(tb_persona_Info Info)
        {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean ModificarDB(tb_persona_Info Info)
        {

            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDB(tb_persona_Info Info)
        {
            try
            {
                return oData.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
