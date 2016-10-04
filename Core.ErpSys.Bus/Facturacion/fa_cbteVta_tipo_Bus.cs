using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fa_cbteVta_tipo_Bus
    {
        fa_cbteVta_tipo_Data oData = new fa_cbteVta_tipo_Data();
        public List<fa_cbteVta_tipo_Info> Get_List_CbteVtaTipo()
        {

            try
            {
                return oData.Get_List_CbteVtaTipo();
            }
            catch (Exception)
            {

                return new List<fa_cbteVta_tipo_Info>();
            }
        }
        public Boolean GrabarDB(fa_cbteVta_tipo_Info Info)
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
        public Boolean ModificarDB(fa_cbteVta_tipo_Info Info)
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
        public Boolean AnularDB(fa_cbteVta_tipo_Info Info)
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
