using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_formaPago_Bus
    {
        fac_formaPago_Data oData = new fac_formaPago_Data();
        public List<fac_formaPago_Info> Get_List_FormaPago(fac_formaPago_Info Info)
        {
            try
            {
                return oData.Get_List_FormaPago(Info);
            }
            catch (Exception)
            {

                return new List<fac_formaPago_Info>();
            }

        }

        public Boolean GrabarDB(fac_formaPago_Info Info)
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
        public Boolean ModificarDB(fac_formaPago_Info Info)
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
