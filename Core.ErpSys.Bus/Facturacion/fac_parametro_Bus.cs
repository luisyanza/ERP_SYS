using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_parametro_Bus
    {
        fac_parametro_Data oData = new fac_parametro_Data();
        public fac_parametro_Info Get_Parametros(int IdEmpresa)
        {

            try
            {
                return oData.Get_Parametros(IdEmpresa );
            }
            catch (Exception)
            {
                
                return new fac_parametro_Info();
            }
        }

        public Boolean GrabarDB(fac_parametro_Info Info)
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
        public Boolean ModificarDB(fac_parametro_Info Info)
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
