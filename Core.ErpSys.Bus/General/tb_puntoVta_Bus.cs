using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.General;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Bus.General
{
    public class tb_puntoVta_Bus
    {
        tb_puntoVta_Data oData = new tb_puntoVta_Data();

        public List<tb_puntoVta_Info> Get_List_PuntoVta(tb_puntoVta_Info Info)
        {

            try
            {
                return oData.Get_List_PuntoVta(Info);
            }
            catch (Exception)
            {

                return new List<tb_puntoVta_Info>();
            }

        }

        public tb_puntoVta_Info Get_Info_PuntoVta(int idEmpresa, int IdpuntoVta)
        {
            try
            {
                return oData.Get_Info_PuntoVta(idEmpresa, IdpuntoVta);
            }
            catch (Exception)
            {

                return new tb_puntoVta_Info();
            }
        }
        public Boolean GrabarDB(tb_puntoVta_Info Info)
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

        public Boolean ModificarDB(tb_puntoVta_Info Info)
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
        public Boolean AnularDB(tb_puntoVta_Info Info)
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
