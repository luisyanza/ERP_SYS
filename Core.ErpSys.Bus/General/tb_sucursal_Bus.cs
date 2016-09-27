using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.General;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Bus.General
{
    public class tb_sucursal_Bus
    {
        tb_sucursal_Data oData = new tb_sucursal_Data();

        public List<tb_sucursal_Info> Get_List_Sucursal(tb_sucursal_Info Info)
        {

            try
            {
                return oData.Get_List_Sucursal(Info);
            }
            catch (Exception)
            {

                return new List<tb_sucursal_Info>();
            }

        }

        public tb_sucursal_Info Get_Info_Sucursal(int idEmpresa, int IdSucursal)
        {
            try
            {
                return oData.Get_Info_Sucursal(idEmpresa,IdSucursal );
            }
            catch (Exception)
            {

                return new tb_sucursal_Info();
            }
        }
        public Boolean GrabarDB(tb_sucursal_Info Info)
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

        public Boolean ModificarDB(tb_sucursal_Info Info)
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
        public Boolean AnularDB(tb_sucursal_Info Info)
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
