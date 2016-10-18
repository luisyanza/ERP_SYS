using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_TipoNota_Bus
    {

        fac_TipoNota_Data oData = new fac_TipoNota_Data();
        public List<fac_TipoNota_Info> Get_List_TipoNota(fac_TipoNota_Info Info)
        {
            try
            {
                return oData.Get_List_TipoNota(Info);
            }
            catch (Exception)
            {

                return new List<fac_TipoNota_Info>();
            }

        }
        public fac_TipoNota_Info Get_Info_TipoNota(int idEmpresa, int IdTipoNota)
        {
            try
            {
                return oData.Get_Info_TipoNota(idEmpresa, IdTipoNota);
            }
            catch (Exception)
            {

                return new fac_TipoNota_Info();
            }
        }

        public Boolean GrabarDB(fac_TipoNota_Info Info)
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
        public Boolean ModificarDB(fac_TipoNota_Info Info)
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
        public Boolean AnularDB(fac_TipoNota_Info Info)
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
