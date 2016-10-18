using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cbteVta_tipo_Bus
    {
        fac_cbteVta_tipo_Data oData = new fac_cbteVta_tipo_Data();
        public List<fac_cbteVta_tipo_Info> Get_List_CbteVtaTipo()
        {

            try
            {
                return oData.Get_List_CbteVtaTipo();
            }
            catch (Exception)
            {

                return new List<fac_cbteVta_tipo_Info>();
            }
        }
        public Boolean GrabarDB(fac_cbteVta_tipo_Info Info)
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
        public Boolean ModificarDB(fac_cbteVta_tipo_Info Info)
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
        public Boolean AnularDB(fac_cbteVta_tipo_Info Info)
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
