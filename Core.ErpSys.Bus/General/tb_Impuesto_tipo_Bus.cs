using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;
using Core.ErpSys.Data.General;


namespace Core.ErpSys.Bus.General
{
    public class tb_Impuesto_tipo_Bus
    {
        tb_Impuesto_tipo_Data oData = new tb_Impuesto_tipo_Data();
        public List<tb_Impuesto_tipo_Info> Get_List_ImpuestoTipo()
        {

            try
            {
                return oData.Get_List_ImpuestoTipo();
            }
            catch (Exception)
            {

                return new List<tb_Impuesto_tipo_Info>();
            }
        }
        public Boolean GrabarDB(tb_Impuesto_tipo_Info Info)
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
        public Boolean ModificarDB(tb_Impuesto_tipo_Info Info) {


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
