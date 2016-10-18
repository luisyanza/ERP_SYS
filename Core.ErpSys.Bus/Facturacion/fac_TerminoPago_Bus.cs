using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_TerminoPago_Bus
    {

        fac_TerminoPago_Data oData = new fac_TerminoPago_Data();
        public List<fac_TerminoPago_Info> Get_List_TerminoPago(fac_TerminoPago_Info Info)
        { 
            try
            {
                return oData.Get_List_TerminoPago(Info);
            }
            catch (Exception)
            {

                return new List<fac_TerminoPago_Info>();
            }

        }

        public Boolean GrabarDB(fac_TerminoPago_Info Info)
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
        public Boolean ModificarDB(fac_TerminoPago_Info Info)
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
