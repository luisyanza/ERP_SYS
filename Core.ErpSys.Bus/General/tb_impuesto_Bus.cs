using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;
using Core.ErpSys.Data.General;


namespace Core.ErpSys.Bus.General
{
    public class tb_impuesto_Bus
    {
        tb_impuesto_Data oData = new tb_impuesto_Data();

        public List<tb_impuesto_Info> Get_List_Impuesto(tb_impuesto_Info Info)
        {
            try
            {
            return oData.Get_List_Impuesto(Info);

            }
            catch (Exception)
            {

                return new List<tb_impuesto_Info>();
            }
        }
        public Boolean GrabarDB(tb_impuesto_Info Info) {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean ModificarDB(tb_impuesto_Info Info)
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
    }
}
