using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_TipoNota_x_tbsucursal_Bus
    {
        fac_TipoNota_x_tbsucursal_Data oData = new fac_TipoNota_x_tbsucursal_Data();

        public fac_TipoNota_x_tbsucursal_Info Get_Info_TipoNota_Sucursal(int IdEmpresa, int IdSucursal, int IdTipoNota)
        {
            try
            {
                return oData.Get_Info_TipoNota_Sucursal(IdEmpresa, IdSucursal, IdTipoNota);
            }
            catch (Exception)
            {

                return new fac_TipoNota_x_tbsucursal_Info();
            }
        
        }

        public Boolean GrabarDB(fac_TipoNota_x_tbsucursal_Info Info)
        {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {
                
                return false ;
            }
        
        }
    }
}
